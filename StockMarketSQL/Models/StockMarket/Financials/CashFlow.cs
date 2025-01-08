using Newtonsoft.Json;

namespace Models.StockMarket.Financials
{
    public class Cashflow
    {
        public DateTime FiscalDateEnding { get; set; }
        public string? ReportedCurrency { get; set; }
        public long? OperatingCashflow { get; set; }
        public long? PaymentsForOperatingActivities { get; set; }
        public long? ProceedsFromOperatingActivities { get; set; }
        public long? ChangeInOperatingLiabilities { get; set; }
        public long? ChangeInOperatingAssets { get; set; }
        public long? DepreciationDepletionAndAmortization { get; set; }
        public long? CapitalExpenditures { get; set; }
        public long? ChangeInReceivables { get; set; }
        public long? ChangeInInventory { get; set; }
        public long? ProfitLoss { get; set; }
        public long? CashflowFromInvestment { get; set; }
        public long? CashflowFromFinancing { get; set; }
        public long? ProceedsFromRepaymentsOfShortTermDebt { get; set; }
        public long? PaymentsForRepurchaseOfCommonStock { get; set; }
        public long? PaymentsForRepurchaseOfEquity { get; set; }
        public long? PaymentsForRepurchaseOfPreferredStock { get; set; }
        public long? DividendPayout { get; set; }
        public long? DividendPayoutCommonStock { get; set; }
        public long? DividendPayoutPreferredStock { get; set; }
        public long? ProceedsFromIssuanceOfCommonStock { get; set; }
        public long? ProceedsFromIssuanceOfLongTermDebtAndCapitalSecuritiesNet { get; set; }
        public long? ProceedsFromIssuanceOfPreferredStock { get; set; }
        public long? ProceedsFromRepurchaseOfEquity { get; set; }
        public long? ProceedsFromSaleOfTreasuryStock { get; set; }
        public long? ChangeInCashAndCashEquivalents { get; set; }
        public long? ChangeInExchangeRate { get; set; }
        public long? NetIncome { get; set; }
    }
	public class CashflowResponse
	{
		[JsonProperty("annualReports")]
		public List<Cashflow>? AnnualReports { get; set; }
	}
}
