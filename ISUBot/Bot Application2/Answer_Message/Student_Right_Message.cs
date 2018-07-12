namespace Bot_Application2.Answer_Message
{
    public class Student_Right_Message
    {
        public static string Student_Right(string message, string br)
        {
            string msg = "關於此問題的回答" + br + "機器人有點錯誤٩(ŏ﹏ŏ、)۶" + br + "將盡快修復" + br + "歡迎詢問其他問題";

            switch (message)
            {
                case "系費":
                    msg = "關於要不要繳交系費，請自行考量哦。" + br +
                        "是否需要強制繳交請參考各系系規" + br +
                        "建議是如果你覺得你參加系上的活動會很多，那就站在使用者付費的角度，請繳交囉" + br +
                        "反之，如果你覺得你可能不太會參加系上活動，那就不用繳交囉 :>";
                    break;
                case "學生優惠":
                    msg = "只要攜帶學生證，去對面的義大購物廣場，部份餐廳可以打9折" + br +
                        "學校賣的東西也會比外面便宜，但是除了影印跟書局的一些文具之外 :< " + br;
                    break;
                case "打工":
                    msg = "學內的一些單位提供打工機會，可以上學校的工讀媒合系統看看唷" + br +
                        "http://www.sa.isu.edu.tw/work/" + br +
                        "對面的購物廣場也有提供打工機會，不過記得請找符合法定薪資\"133/H\"的唷";
                    break;
                case "死當":
                    msg = "死當的分數為40分以下，死當會擋修系上的一些課程，請詢問各系辦";
                    break;
                case "體育":
                    msg = "體育為大二上下學期的必修課程，不過是0學分" + br +
                        "可以自己選要做哪些運動" + br +
                        "籃球、排球、網球、桌球、羽球、游泳、高爾夫、有氧舞蹈、浮潛、撞球、體適能瑜珈" + br +
                        "詳細介紹請上DCARD搜尋相關關鍵字 在此不一一介紹 請見諒";
                    break;
                case "英文門檻":
                    msg = "英文門檻為各系的畢業門檻，要達到才可畢業" + br +
                        "詳情請詢問各系辦";
                    break;
                case "助教":
                    msg = "助教為大一以上，在各課程擔任教學助理，想當助教可以去詢問系上教授";
                    break;
                case "車行介紹":
                    msg = "震撼、慶X 這兩家是極力不推薦的店家" + br +
                        "其他同學推薦的店家為：" + br +
                        "社一、鐙寬、鋐昌" + br +
                        "有其他推薦或反推薦的歡迎留言 :))";
                    break;
                case "體育老師":
                    msg = "作者我只上過宋一夫、吳俊賢這兩位老師的高爾夫" + br +
                        "個人覺得蠻好過的，只是高爾夫每次上課需要花45塊買球" + br +
                        "其他老師請上Dcard搜尋相關關鍵字唷" + br + "(›´ω`‹ )";
                    break;
                case "宵夜":
                    msg = "在義守這種地方，是沒有宵夜可以吃的" + br +
                        "唯一的宵夜可能是販賣機的泡麵" + br +
                        "或是趁著全家還沒打烊前，趕快衝去買" + br +
                        "不然只剩下下山去大社吃了" + br + "(๑•́ ₃ •̀๑)" + br;
                    break;
                case "通識推薦":
                    msg = "通識推薦請參考DCARD " + br +
                        "在上方搜尋框中輸入想找的課程名稱或開課老師" +
                        "DCARD義守版：" + br + " https://www.dcard.tw/f/isu " + br +
                        "DCARD懶人包：" + br + " https://goo.gl/1N4tbE " + br;
                    break;
                case "周邊美食":
                    msg = "義守的周邊美食請到DCARD義守版" + br +
                        "搜尋相關關鍵字：美食、大社" + br +
                        "Dcard：https://goo.gl/8nC3Dn";
                    break;
            }
            return msg;
        }
    }
}