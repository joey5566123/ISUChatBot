namespace Bot_Application2.Answer_Message
{
    public class Talk_Message
    {
        public static string Talk(string message, string br)
        {
            string msg = "關於此問題的回答" + br + "機器人有點錯誤٩(ŏ﹏ŏ、)۶" + br + "將盡快修復" + br + "歡迎詢問其他問題";

            switch (message)
            {
                case "某課程好過嗎":
                    msg = "關於某個課好不好過可以上DCARD查詢" + br +
                        "關鍵字可以輸入課程名稱" + br +
                        "畢竟這是很主觀的，請多比較多參考" + br +
                        "https://www.dcard.tw/f/isu";
                    break;
                case "某老師如何":
                    msg = "老師的相關推薦或反推薦" + br +
                        "請上DCARD義守版搜尋相關關鍵字" + br +
                        "畢竟這是很主觀的，請多比較多參考" + br +
                        "https://www.dcard.tw/f/isu";
                    break;
                case "某系好進嗎":
                    msg = "請使用網路上推薦的落點分析系統" + br +
                        "因為每年的最低錄取分數不一定會公布哦~" + br +
                        "http://www.com.tw/cross/ap.html";
                    break;
                case "翹課":
                    msg = "關於翹課這件事，本機器人也不好說啊~" + br +
                        "要不要翹課是看個人，如果仔細想想之後覺得翹課是划算的，那就翹吧 :>" + br +
                        "真的沒辦法決定就讓機器人幫你決定吧" + br +
                        "機器人經過思考之後決定：";
                    break;
                case "讀書":
                    msg = "讀書要加油哦！";
                    break;
                case "某間店如何":
                    msg = "關於某間店的評價可以上網GOOGLE查詢" + br +
                        "如果是學校附近的，或許可以上DCARD義守版上查詢看看";
                    break;
                case "某社團好玩嗎":
                    msg = "關於某社團，可以先去參加各社團的期初活動哦~" + br +
                        "通常期初活動是沒有參加限制的" + br +
                        "大學社團生活多采多姿" + br +
                        "玩社團也要兼顧學業嘿" + br + "d(`･∀･)b";
                    break;
                case "幹話":
                    msg = "我不知道欸(๑•́ ₃ •̀๑)";
                    break;
                case "再見":
                    msg = "掰掰 (｡◕∀◕｡)";
                    break;
                case "感謝":
                    msg = "不客氣 (ﾉ◕ヮ◕)ﾉ*:･ﾟ✧";
                    break;
            }
            return msg;
        }
    }
}