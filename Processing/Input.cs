using InvestTool.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace InvestTool.Processing
{
    class Input
    {
        private BuyModel m_buyModel;
        private SellModel m_sellModel;
        private PortfolioOverviewModel m_portfolioOverviewModel;

        public Input()
        {
            LoadModels();
        }

        private void LoadModels()
        {
            m_buyModel = new BuyModel();
            m_sellModel = new SellModel();
            m_portfolioOverviewModel = new PortfolioOverviewModel();
        }
    }
}
