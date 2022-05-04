using System;
namespace myCard
{


    public class Card
    {
        private string Owner;
        private DateTime Validation;

        public enum Bank
        {
            OTP,
            KANDH,
            ERSTE,
            CIB
        }

        private Bank _bank;

        public Bank get__bank()
        {
            return this._bank;
        }

        public void set_bank(Bank _bank)
        {
            this._bank = _bank;
        }

        private int Balance;

        public Card(string owner, DateTime validation, Bank bank, int balance)
        {
            Owner = owner;
            Validation = validation;
            _bank = bank;
            Balance = balance;

        }

        public string getOwner()
        {
            return this.Owner;
        }

        public void setOwner(string Owner)
        {
            this.Owner = Owner;
        }

        public DateTime getValidation()
        {
            return this.Validation;
        }

        public void setValidation(DateTime Validation)
        {
            this.Validation = Validation;
        }


        public int getBalance()
        {
            return this.Balance;
        }

        public void setBalance(int balance)
        {
            this.Balance = balance;
        }

        public virtual bool withDrawal(int amount)
        {

            if (amount > Balance || Validation < DateTime.Now)
            {
                return false;
            }
            else
            {
                Balance -= amount;
                return true;
            }


        }



        public override String ToString() { return "Card :" + Owner + " " + Validation + " " + Balance + " " + _bank; }




    }
    public class CreditCard : Card, IComparable<CreditCard>
    {
        private int CreditLine;


        public int getCreditLine()
        {
            return this.CreditLine;
        }

        public void setCreditLine(int CreditLine)
        {
            this.CreditLine = CreditLine;
        }

        public CreditCard(string owner, DateTime validation, Bank bank, int balance) : base(owner, validation, bank, balance)
        {
            CreditLine = 100000;
        }
        public CreditCard(string owner, DateTime validation, Bank bank, int balance, int creditLine) : base(owner, validation, bank, balance)
        {
            CreditLine = creditLine;
        }

        public override bool withDrawal(int amount)
        {

            if (!(base.withDrawal(amount)) && amount < CreditLine)
            {

                CreditLine -= (amount - base.getBalance());
                base.setBalance(0);
                return true;
            }
            else
            {
                return false;
            }


        }

        public int CompareTo(CreditCard cc)
        {


            return this.getValidation().CompareTo(cc.getValidation());

        }

        public override String ToString() { return base.ToString() + " " + CreditLine; }

    }


}

namespace ujNevter
{
    public class CardTest
    {
        public static void Main(string[] args)
        {

            var my2 = new myCard.CreditCard[4];
            my2[0] = new myCard.CreditCard("kiss tamas", new DateTime(2020, 04, 30), myCard.Card.Bank.OTP, 150000, 100000);
            my2[1] = new myCard.CreditCard("Nagy Levente", new DateTime(2022, 05, 31), myCard.Card.Bank.ERSTE, 100000);
            my2[2] = new myCard.CreditCard("Szabó László,", new DateTime(2019, 03, 31), myCard.Card.Bank.OTP, 200000, 100000);
            my2[3] = new myCard.CreditCard("Kovács edit", new DateTime(2021, 01, 31), myCard.Card.Bank.CIB, 250000);

            System.Console.WriteLine(my2[0].withDrawal(280000));
            System.Console.WriteLine(my2[0]);
            System.Console.WriteLine(my2[1].withDrawal(80000));
            System.Console.WriteLine(my2[1]);
            System.Console.WriteLine(my2[2].withDrawal(50000));
            System.Console.WriteLine(my2[2]);
            System.Console.WriteLine(my2[3].withDrawal(100000));
            System.Console.WriteLine(my2[3]);


            void countCib(myCard.CreditCard[] tomb)
            {
                int sum = 0;
                foreach (var item in tomb)
                {
                    if (item.get__bank() == myCard.Card.Bank.CIB)
                    {
                        sum++;
                    }
                }
                System.Console.WriteLine(sum);

            }

            countCib(my2);

            Array.Sort(my2);

            foreach (var item in my2)
            {
                System.Console.WriteLine(item.getValidation());
            }

        }
    }
}