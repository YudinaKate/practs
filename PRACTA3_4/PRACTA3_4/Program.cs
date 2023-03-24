using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTA3_4
{
    class SmsMessage
        {
            private string messagetext;
            private int maxlength;
            private double initialprice;
            private double symbolprice;
            public string MessageText
            {
                get
                {
                    return messagetext;
                }
                private set
                {
                    messagetext = NormalizeMessageText(value, maxlength);
                }
            }
            public int MaxLength
            {
                get
                {
                    return maxlength;
                }
                private set
                {
                    maxlength = value;
                }
            }
            public double InitialPrice
            {
                get
                {
                    return initialprice;
                }
                private set
                {
                    initialprice = value;
                }
            }
            public double SymbolPrice
            {
                get
                {
                    return symbolprice;
                }
                private set
                {
                    symbolprice = value;
                }
            }
            private double Price
            {
                get
                {
                    return CountPrice(initialprice, symbolprice);
                }
            }
            public SmsMessage(string text, int length, double initialprice, double symbolprice)
            {
                MessageText = text;
                MaxLength = length;
                InitialPrice = initialprice;
                SymbolPrice = symbolprice;
            }
            public void SendMessage()
            {

                Console.WriteLine($"Отправлено сообщение '{messagetext}' длиной {messagetext.Length} символов и стоимостью {Price} руб.");
            }
            private string NormalizeMessageText(string text, int length)
            {
                if (text.Length > length)
                {
                    return text.Substring(0, text.Length - length);
                }
                return text;
            }
            private double CountPrice(double initialprice, double symbolprice)
            {
                if (messagetext.Length < 65)
                {
                    return initialprice;
                }
                else
                {
                    int length = MessageText.Length - 65;
                    return initialprice + length * symbolprice;
                }
            }
        }
    class Program
    {
        static void Main(string[] args)
        {
            SmsMessage sms = new SmsMessage("Поступил платеж на 100 руб. Спасибо, что пользутесь нашими услугами!", 53, 3, 0.9);
            sms.SendMessage();
            Console.ReadKey(true);
        }
    }
}
