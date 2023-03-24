using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTA3_1
{
    internal class Program
    {
        class SmsMessage
        {
            private string messagetext;
            public string MessageText
            {
                get
                {
                    return messagetext;
                }
                private set
                {
                    messagetext = NormalizeMessageText(value);
                }
            }
            private double Price
            {
                get
                {
                    return CountPrice();
                }
            }
            public SmsMessage(string text)
            {
                MessageText = text;
            }
            public void SendMessage()
            {

                Console.WriteLine($"Отправлено сообщение '{messagetext}' длиной {messagetext.Length} символов и стоимостью {Price} руб.");
            }
            private string NormalizeMessageText(string text)
            {
                if (text.Length > 250)
                {
                    return text.Substring(0, text.Length - 250);
                }
                return text;
            }
            private double CountPrice()
            {
                if (messagetext.Length < 65)
                {
                    return 1.5;
                } else
                {
                    int length = MessageText.Length - 65;
                    return 1.5 + length * 0.5;
                }
            }
        }
        static void Main(string[] args)
        {
            SmsMessage sms = new SmsMessage("Поступил платеж 100 руб. Спасибо, что пользуетесь нашими услугами!");
            sms.SendMessage();
            Console.ReadKey(true);
        }
    }
}
