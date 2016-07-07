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
        private string DetermineCrop(string seasonToCheck)
        {
            string currentCrop;
            int cost;
            int salePrice;
            int daysToGrow;
            int daysToRegrow;

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

                profitPerDay = (((salePrice - cost) * numberOfPlantings) /
                    daysLeftInSeason)*numberPlayerCanBuy;

                bool biggerProfit = profitPerDay > profitChecked;
                if (biggerProfit)
                {
                    // store currently tracked profit
                    profitChecked = profitPerDay;
                }
                if (resultList.Count == 0)
                {
                    resultList.Add(currentCrop);
                }
                else if (biggerProfit)
                {
                    resultList.Insert(0, currentCrop);
                }
                else
                {
                    resultList.Add(currentCrop);
                }

                if (resultList.Count > 3)
                {
                    resultList.RemoveAt(3);
                }
            }

            if (resultList.Count > 0)
            {
                result = "";
                result = string.Join("\n", resultList);
            }
            return result;
        }

        /// <summary>
        /// calcultes the crop the user should use, if any
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void calcButton_Click(object sender, EventArgs e)
        {
            // declare vars to store data and results in while working
            

            // process information and return recommendation
            switch (season)
            {
                case SeasonEnum.Spring:
                    cropLabel.Text = DetermineCrop("Spring");
                    break;
                case SeasonEnum.Summer:
                    cropLabel.Text = DetermineCrop("Summer");
                    break;
                case SeasonEnum.Fall:
                    cropLabel.Text = DetermineCrop("Fall");
                    break;
                case SeasonEnum.Winter:
                    cropLabel.Text = "Wild Seeds (Wi)";
                    break;
            }
        }
    }
}
