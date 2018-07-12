namespace Bot_Application2.Answer_Message
{
    public class Department_Introduction_Message
    {
        public static string Department_Introduction(string message, string teacher_name,string br)
        {
            string msg = "關於此問題的回答" + br + "機器人有點錯誤٩(ŏ﹏ŏ、)۶" + br + "將盡快修復" + br + "歡迎詢問其他問題";

            switch (message)
            {
                case "資工系":
                    msg = "資工系位於科技大樓7樓" + br + "於西元1990年時創校即成立" + br +
                        "http://www.csie.isu.edu.tw/upload/80203/index.html ";
                    break;
                case "政管系":
                    msg = "政管系位於行政大樓8樓" + br + "於西元2000年成立" + br +
                        "http://www.ppm.isu.edu.tw/interface/overview.php?dept_mno=366 ";
                    break;
                case "資管系":
                    msg = "資管系位於科技大樓5樓" + br + "於西元1991年成立" + br +
                        "http://www.mis.isu.edu.tw/interface/overview/80204 ";
                    break;
                case "材料系":
                    msg = "材料系位於理工大樓1樓" + br + "於西元1994年成立" + br +
                        "http://www.mse.isu.edu.tw/interface/overview.php?dept_mno=400 ";
                    break;
                case "電子系":
                    msg = "電子系位於科技大樓6樓" + br + "於西元1990年時創校即成立" + br +
                        "http://www.ene.isu.edu.tw/interface/overview.php?dept_mno=52 ";
                    break;
                case "大傳系":
                    msg = "大傳系位於綜教大樓10樓" + br + "於西元2000年時成立" + br +
                        "http://www.dmcnew.isu.edu.tw/ ";
                    break;
                case "商設系":
                    msg = "商設系位於綜教大樓12樓" + br + "於西元2011年時成立" + br +
                        "http://www.cpd.isu.edu.tw/interface/overview.php?dept_mno=275 ";
                    break;
                case "數媒系":
                    msg = "數媒系位於綜教大樓12樓" + br +
                        "http://www.dmmd.isu.edu.tw/interface/overview.php?dept_mno=277 ";
                    break;
                case "資工系老師":
                    msg = teacher_name + " 為資工系教授" + br + "ヾ(●゜▽゜●)♡ ";
                    break;
                case "材料系老師":
                    msg = teacher_name + " 為材料系教授" + br + "ヾ(●゜▽゜●)♡ ";
                    break;
                case "電機系老師":
                    msg = teacher_name + " 為電機系教授" + br + "ヾ(●゜▽゜●)♡ ";
                    break;
                case "數媒系老師":
                    msg = teacher_name + " 為數媒系教授" + br + "ヾ(●゜▽゜●)♡ ";
                    break;
            }
            return msg;
        }
    }
}