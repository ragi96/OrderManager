namespace OrderManagement.Data.Model
{
    public class YearlyCompareModel
    {
        public int Year { get; set; }

        public QuarterData Q1Data { get; set; }

        public QuarterData Q2Data { get; set; }

        public QuarterData Q3Data { get; set; }

        public QuarterData Q4Data { get; set; }
    }

    public class QuarterData
    {
        public int NumOfOrders { get; set; }

        public int NumOfArticles { get; set; }

        public double AvgArticlePerOrder { get; set; }

        public double TotalSalesPerCustomer { get; set; }

        public double TotalSales { get; set; }
    }
}
