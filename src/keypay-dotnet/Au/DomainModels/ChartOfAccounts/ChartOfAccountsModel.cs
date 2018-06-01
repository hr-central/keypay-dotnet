using System.Collections.Generic;

namespace KeyPay.Au.DomainModels.ChartOfAccounts
{
    public class ChartOfAccountsModel
    {
        public bool Complete { get; set; }
        public ChartOfAccountsGroupModel ChartofAccounts { get; set; }
        public List<ChartOfAccountsLocationGroupModel> LocationSpecificChartOfAccounts { get; set; }
    }
}