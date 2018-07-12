namespace Bot_Application2.Answer_Message
{
    public class Mall_Introduction_Message
    {
        

        public static string Mall_Introduction(string message, string br)
        {
            string msg = "關於此問題的回答 " + br + " 機器人有點錯誤٩(ŏ﹏ŏ、)۶ " + br + " 將盡快修復" + br + "歡迎詢問其他問題";

            switch (message)
            {
                case "麥當勞":
                    msg = "麥當勞位於義大購物廣場C區三樓。";
                    break;
                case "購物廣場介紹":
                    msg = "義大購物廣場為一棟有三個區域(A、B、C)的建築物" + br +
                        "各區域所販賣的東西都不同" + br +
                        "相同區域的東西會類似" + br +
                        "義大學生常逛的一些地方：" + br +
                        "國賓電影院 C區3樓" + br +
                        "麥當勞 C區3樓";
                    break;
            }

            return msg;
        }
    }
}