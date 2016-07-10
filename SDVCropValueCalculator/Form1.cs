using System;
using System.Collections.Generic;
using System.Windows.Forms;

/// <summary>
/// Stardew Valley Crop Value Calculator
/// </summary>
namespace SDVCropValueCalculator
{
    /// <summary>
    /// Enumeration for seasons
    /// </summary>
    public enum SeasonEnum
    {
        Spring,
        Summer,
        Fall,
        Winter
    };

    /// <summary>
    /// The main form
    /// </summary>
    public partial class Form1 : Form
    {
        // declare input variables
        public int moneyOnHand;
        public int day;
        public SeasonEnum season;
        public int fertilizerMod = 0;
        public int perkMod = 0;
        public string recommendedCrop;
        public List<string[]> cropData;

        /// <summary>
        /// Main form constructor
        /// </summary>
        public Form1()
        {
            // load and store cropdata
            cropData = SimpleCSVParser.parseFile(@"data\CropData.csv");
            // data now stored in fields in this format:
            // Spring,Cauliflower,80,175,12,0
            //   ^        ^       ^   ^   ^ ^
            // Season   Crop      |   |   | |
            //                 Cost   |   | |
            //               Sale Price   | |
            //                 Days to grow |
            // Regrows in this many days if at all

            InitializeComponent();
        }

        /// <summary>
        /// Stores the value from the money control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void moneyInputControl_TextChanged(object sender, EventArgs e)
        {
            string money = moneyInputControl.Text;
            try
            {
                moneyOnHand = int.Parse(money);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                moneyInputControl.Text = "0";
            }
        }

        /// <summary>
        /// Stores the value from the day dropdown control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dayDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
           day = int.Parse(dayDropDown.SelectedItem.ToString());
        }

        /// <summary>
        /// Stores the value from the season dropdown control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void seasonDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            string season = seasonDropDown.SelectedItem.ToString();
            switch (season)
            {
                case "Spring":
                    this.season = SeasonEnum.Spring;
                    break;
                case "Summer":
                    this.season = SeasonEnum.Summer;
                    break;
                case "Fall":
                    this.season = SeasonEnum.Fall;
                    break;
                case "Winter":
                    this.season = SeasonEnum.Winter;
                    break;
            }
        }

        /// <summary>
        /// Determines the best possible crop to grow in given season, if any are available.
        /// </summary>
        /// <param name="seasonToCheck">The season to perform the check on</param>
        /// <returns></returns>
        private string DetermineCrop(string seasonToCheck, int mod)
        {
            // declare variables used in the calculation.
            string currentCrop;
            int cost;
            int salePrice;
            int daysToGrow;
            int daysToRegrow;

            // days left in season is simply the total days in a season, minus the day we're on.
            // we don't need to include the current day because growth times don't take into
            // account the day in which they were planted, as is stated on the wiki.
            int daysLeftInSeason = 28 - day;

            int numberPlayerCanBuy;
            int profitPerDay;
            int profitChecked = 0;

            // prepare a result to return if no crop passes evaluation
            string result = "No crop available";
            List<string> resultList = new List<string>();

            foreach (string[] row in cropData)
            {
                // only process a row if it's in the right season
                if (row[0] != seasonToCheck)
                {
                    continue;
                }

                // track the current crop's name
                currentCrop = row[1];

                // if the season is summer and the crop is corn,
                // include an extra 28 days (a full season) in the time left
                if(currentCrop == "Corn" && seasonToCheck == "Summer")
                {
                    // we repeated a check for season here,
                    // but it's necessary because corn is a special case
                    daysLeftInSeason += 28;
                }

                if(currentCrop == "Sweet Gem Berry")
                {
                    currentCrop = "Sweet Gem Berry*";
                    commentLabel.Text = "* seeds have to be bought during spring or summer " +
                        "from the merchant on thursdays or sundays.";
                }

                // check if any of it can be bought
                cost = int.Parse(row[2]);
                if (cost > moneyOnHand)
                {
                    // cost is more than player has... can't buy so don't process
                    continue;
                }
                else
                {
                    // if i reach this else than player can buy at least one seed
                    // store amount player can buy
                    numberPlayerCanBuy = moneyOnHand / cost;
                }

                // store sale price
                salePrice = int.Parse(row[3]);

                // ascertain whether crop can be grown in the time left
                daysToGrow = int.Parse(row[4]);
                daysToGrow -= daysToGrow * mod / 100;
                if (daysToGrow > daysLeftInSeason)
                {
                    // not enough time left to grow crop.. don't process
                    continue;
                }

                // store regrow time
                daysToRegrow = int.Parse(row[5]);

                // determine total profit
                // if profit for current crop larger than previous profit stored
                int numberOfPlantings = 1;
                if (daysToRegrow != 0)
                {
                    // if the plant is reharvestable, calculate that into number of plantings
                    numberOfPlantings += (daysLeftInSeason - daysToGrow) / daysToRegrow;
                }
                else
                {
                    // otherwise just divide daysLeftInSeason minus one planting's worth of time
                    // by the time it would take antother planting to reach harvest.
                    numberOfPlantings += (daysLeftInSeason - daysToGrow) / daysToGrow;
                }

                // calculate the total profit per day the current crop can achieve.
                profitPerDay = (((salePrice - cost) * numberOfPlantings) /
                    daysLeftInSeason)*numberPlayerCanBuy;

                // store a possible result
                string currentCropResult = numberPlayerCanBuy + " " + currentCrop;

                // check if the current profit is bigger than the last checked,
                // and store boolean result in a variable.
                bool biggerProfit = profitPerDay > profitChecked;

                // track the the profit currenly checked if its bigger than the previous,
                // with the starting value being zero.
                if (biggerProfit)
                {
                    // store currently tracked profit
                    profitChecked = profitPerDay;
                }

                // if there are no crops in the top 3 list, add the current one.
                if (resultList.Count == 0)
                {
                    resultList.Add(currentCropResult);
                }
                // otherwise, and if the current profit tracked was bigger thn the previous,
                // add the current crop to the top of the list.
                else if (biggerProfit)
                {
                    resultList.Insert(0, currentCropResult);
                }
                // if profit tracked ISN'T bigger than the previous one,
                // add the current crop at the end of the list.
                else
                {
                    resultList.Add(currentCropResult);
                }

                // TODO: check, on paper, whether this system works.

                // finally, if the list is now larger than 3 items, truncate it.
                // this if statement means the list NEVER grows bigger than 4 elements,
                // so i only ever have to remove the element at index 3.
                // It never grows any bigger than 4 elements because I remove the element
                // at index 3 if it's got more than 3 elements in.
                // lol @ logic
                if (resultList.Count > 3)
                {
                    // if the entry we're removing is a sweet gem, we'll remove the comment, too.
                    if (resultList[3] == numberPlayerCanBuy + " Sweet Gem Berry*")
                    {
                        commentLabel.Text = "";
                    }
                    resultList.RemoveAt(3);
                }
            }

            // at the start of the function, the result string is set to "No crop available".
            // if in fact we found some crops the player could grow, then the result list
            // would contain more than 0 elements.
            if (resultList.Count > 0)
            {
                // if the result list is populated at all, meaning we found potential crops,
                // then we replace the initil result string with a string containing all the
                // results in the list, joined by a newline character, meaning you get them
                // as a column of up to 3 crops.
                result = "";
                result = string.Join("\n", resultList);
            }

            // return the result string.
            return result;
        }

        /// <summary>
        /// displays the crop the user should use, if any
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void calcButton_Click(object sender, EventArgs e)
        {
            // check modifier status
            checkModifierStatus();
            int totalMod = fertilizerMod + perkMod;

            // process information and return recommendation
            switch (season)
            {
                case SeasonEnum.Spring:
                    cropLabel.Text = DetermineCrop("Spring", totalMod);
                    break;
                case SeasonEnum.Summer:
                    cropLabel.Text = DetermineCrop("Summer", totalMod);
                    break;
                case SeasonEnum.Fall:
                    cropLabel.Text = DetermineCrop("Fall", totalMod);
                    break;
                case SeasonEnum.Winter:
                    cropLabel.Text = "Wild Seeds (Wi)";
                    break;
            }
        }

        /// <summary>
        /// Checks which growth speed modifiers are reported by the player in the form,
        /// determining the total modifier value.
        /// </summary>
        private void checkModifierStatus()
        {
            foreach (RadioButton rdoButton in radioGroup.Controls)
            {
                if(rdoButton.Checked)
                {
                    if (rdoButton.Name == "noGro")
                    {
                        fertilizerMod = 0;
                    }
                    else if (rdoButton.Name == "speedGro")
                    {
                        fertilizerMod = 10;
                    }
                    else if (rdoButton.Name == "deluxeGro")
                    {
                        fertilizerMod = 25;
                    }
                }
                if(isAgriculturist.Checked)
                {
                    perkMod = 10;
                }
                else
                {
                    perkMod = 0;
                }
            }
        }
    }
}
