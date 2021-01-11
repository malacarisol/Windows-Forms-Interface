using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Malacari_Zgaib
{
    class Objeto
    {
        public Objeto(string paais, string itemtype, string order, string number)//constructor para poder acceder de otro file
        {
            pais = paais;
            itemType = itemtype;
            orderID = order;
            unitsSold = number;
        }
        ~Objeto() { }
        public string pais { get; set; }
        public string itemType { get; set; }
        public string orderID { get; set; }
        public string unitsSold { get; set; }
        public string imprimir()
        {
            return pais + " " + itemType + " " + orderID + " " + unitsSold + "\n";
        }
    }
}
