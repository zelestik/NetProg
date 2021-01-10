using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetProg3
{
    class Connection
    {
        // Все методы класса возвращают строку с ответом на запрос или null - если возникла ошибка при подключении
        // Поле для отладки, -2 - проблемы при подключении, -1 - ошибка доступа, 1 - запрос был выполнен успешно
        public int Status { get; private set; }
        public string ExceptionMessage { get; private set; }

        // Метод получения JSON с сервера по адресу запроса (adr)
        public string GetJSON(string adr)
        {
            try
            {
                WebRequest request = WebRequest.Create("http://localhost:3000/" + adr);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream receiveStream = response.GetResponseStream();
                string answer = new StreamReader(response.GetResponseStream()).ReadToEnd();
                return answer;
            }
            catch (Exception e)
            {
                // Запись сообщения об ошибки для отладки
                ExceptionMessage = e.Message;
                return null;

            }
        }

        public string DeleteJSON(string adr)
        {
            try
            {
                WebRequest request = WebRequest.Create("http://localhost:3000/" + adr);
                request.Method = "DELETE";
                request.ContentType = "application/json";
                Stream dataStream = request.GetRequestStream();
                dataStream.Close();
                WebResponse response = request.GetResponse();
                var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
                return responseString;
            }
            catch (Exception e)
            {
                // Запись сообщения об ошибки для отладки
                ExceptionMessage = e.Message;
                return null;

            }
        }

        // метод отправки JSON на сервер, adr - параметр запроса, str - JSON тело запроса
        public string PostJSON(string adr, string str)
        {
            try
            {
                WebRequest request = WebRequest.Create("http://localhost:3000/" + adr);
                request.Method = "POST";
                string postData = str;
                byte[] byteArray = Encoding.UTF8.GetBytes(postData);
                request.ContentType = "application/json";
                request.ContentLength = byteArray.Length;
                Stream dataStream = request.GetRequestStream();
                dataStream.Write(byteArray, 0, byteArray.Length);
                dataStream.Close();
                WebResponse response = request.GetResponse();
                var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
                return responseString;
            }
            catch (Exception e)
            {
                // Запись сообщения об ошибки для отладки
                ExceptionMessage = e.Message;
                return null;

            }
        }

        public string PutJSON(string adr, string str)
        {
            try
            {
                WebRequest request = WebRequest.Create("http://localhost:3000/" + adr);
                request.Method = "PUT";
                string postData = str;
                byte[] byteArray = Encoding.UTF8.GetBytes(postData);
                request.ContentType = "application/json";
                request.ContentLength = byteArray.Length;
                Stream dataStream = request.GetRequestStream();
                dataStream.Write(byteArray, 0, byteArray.Length);
                dataStream.Close();
                WebResponse response = request.GetResponse();
                var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
                return responseString;
            }
            catch (Exception e)
            {
                // Запись сообщения об ошибки для отладки
                ExceptionMessage = e.Message;
                return null;

            }
        }

       

    }
}