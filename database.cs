using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.OleDb;
using System.Text;
using System.Threading.Tasks;

namespace DBSTRAH
{
    class database
    {
        public string selectSotr = "SELECT Страхователь.КодСтрахователь, (Страхователь.Фамилия &' '& Страхователь.Имя &' '& Страхователь.Отчество) AS ФИО, Страхователь.ДатаРождения, Страхователь.Город, Страхователь.Улица, Страхователь.Дом, Страхователь.Квартира, Страхователь.НомерТелефона, Страхователь.ЭлектроннаяПочта, Страхователь.СерияПаспорта, Страхователь.НомерПаспорта FROM Страхователь;";

        public OleDbConnection connect = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=1.mdb");
    }
}
