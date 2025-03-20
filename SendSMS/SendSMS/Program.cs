namespace SendSMS
{
    internal class Program
    {
        private static readonly string apiKey = "uae3845e1150e5c23ab70319ae4c7590d8a7472a0e46226c226460a0010eb45ab431f4"; // Замініть на ваш API-ключ
        private static readonly string apiUrl = "https://api.mobizon.ua/service/message/sendSmsMessage";

        static async Task Main(string[] args)
        {
            try
            {
                string phoneNumber = "380662385408"; // Номер отримувача у міжнародному форматі
                string message = "Привіт! Усім хрошого настрою.";

                string response = await SendSms(phoneNumber, message);
                Console.WriteLine(response);
            }
            catch (Exception ex) {
                Console.WriteLine("Error "+ ex.Message);
            }
        }

        public static async Task<string> SendSms(string recipient, string text)
        {
            using (HttpClient client = new HttpClient())
            {
                var content = new FormUrlEncodedContent(new[]
                {
                new KeyValuePair<string, string>("recipient", recipient),
                new KeyValuePair<string, string>("text", text),
                new KeyValuePair<string, string>("apiKey", apiKey)
            });

                HttpResponseMessage response = await client.PostAsync(apiUrl, content);
                string responseBody = await response.Content.ReadAsStringAsync();

                return responseBody;
            }
        }
    }
}
