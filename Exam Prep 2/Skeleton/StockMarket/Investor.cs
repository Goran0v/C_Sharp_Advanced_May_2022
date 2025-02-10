using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;

namespace StockMarket
{
    public class Investor
    {
        public List<Stock> Portfolio { get; set; }
        public string FullName { get; set; }
        public string EmailAdress { get; set; }
        public decimal MoneyToInvest { get; set; }
        public string BrokerName { get; set; }

        public Investor(string fullName, string emailAdress, decimal moneyToInvest, string brokerName)
        {
            this.Portfolio = new List<Stock>();
            this.FullName = fullName;
            this.EmailAdress = emailAdress;
            this.MoneyToInvest = moneyToInvest;
            this.BrokerName = brokerName;
        }

        public int Count => this.Portfolio.Count;

        public void BuyStock(Stock stock)
        {
            if (stock.MarketCapitalization > 10000 && this.MoneyToInvest - stock.PricePerShare > 0)
            {
                this.MoneyToInvest -= stock.PricePerShare;
                this.Portfolio.Add(stock);
            }
        }

        public string SellStock(string companyName, decimal sellPrice)
        {
            if (this.Portfolio.Count > 0)
            {
                foreach (var stock in this.Portfolio)
                {
                    if (stock.CompanyName == companyName)
                    {
                        if (stock.PricePerShare < sellPrice)
                        {
                            this.Portfolio.Remove(stock);
                            this.MoneyToInvest += sellPrice;
                            return $"{companyName} was sold.";
                        }
                        else
                        {
                            return $"Cannot sell {companyName}.";
                        }
                    }
                }
            }

            return $"{companyName} does not exist.";
        }

        public Stock FindStock(string companyName)
        {
            if (this.Portfolio.Count > 0)
            {
                foreach (var stock in this.Portfolio)
                {
                    if (stock.CompanyName == companyName)
                    {
                        return stock;
                    }
                }
            }
            
            return null;
        }

        public Stock FindBiggestCompany()
        {
            if (this.Portfolio.Count > 0)
            {
                return this.Portfolio.OrderByDescending(s => s.MarketCapitalization).First();
            }

            return null;
        }

        public string InvestorInformation()
        {
            return $"The investor {this.FullName} with a broker {this.BrokerName} has stocks:" + Environment.NewLine + string.Join(Environment.NewLine, this.Portfolio);
        }
    }
}