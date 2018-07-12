using Bot_Application2.Answer_Message;
using Bot_Application2.Dialogs;
using System;
using System.Linq;

namespace Bot_Application2.Model
{
    public class Result_Message_Selection
    {

        public static string Message_Selection(LUISResponse LUIS_Object, string user_name, string br)
        {
            string result_message = "此問題的回答" + br + "機器人部份有點錯誤٩(ŏ﹏ŏ、)۶" + br + "將盡快修復" + br + "歡迎詢問其他問題";

            string Group = "";

            switch (LUIS_Object.topScoringIntent.intent)
            {
                case "閒聊":

                    if (LUIS_Object.entities.Length > 1)
                    {
                        Group = Get_First_Entities(LUIS_Object);
                    }
                    else { Group = LUIS_Object.entities.First().type; }

                    string[] Group_Split = Group.Split(':', ':');

                    switch (Group_Split[0])
                    {
                        case "垃圾話":
                            result_message = "ლ(・ω・ლ)";
                            break;
                        case "閒聊":
                            result_message = Talk_Message.Talk(Group_Split[2], br);
                            if (Group_Split[2] == "翹課")
                            {
                                Random rd = new Random(Guid.NewGuid().GetHashCode());
                                int rdm = rd.Next();
                                if (rdm % 2 == 0)
                                {
                                    result_message = result_message + br + "翹吧" + br + "(✪ω✪)";
                                }
                                else result_message = result_message + br + "乖乖上課" + br + "ლ(́◕◞౪◟◕‵ლ)";
                            }
                            break;
                        case "問候":
                            result_message = "你好 " + user_name + br + "歡迎使用義守萬事通" + br + " (〃∀〃)~♡ ";
                            break;
                        case "學校介紹1":
                            result_message = Introduction_Message.School_Introduction(Group_Split[2], br);
                            break;
                        case "軟體與作者介紹":
                            result_message = Introduction_Message.Self_Introduction(Group_Split[2], br);
                            break;
                        case "學校餐廳介紹":
                            result_message = Introduction_Message.Restaurant_Introduction(Group_Split[2], br);
                            break;
                        case "新生":
                            result_message = New_Student_Message.New_Student(user_name, br);
                            break;
                    }
                    break;

                case "介紹":

                    if (LUIS_Object.entities.Length > 1)
                    {
                        Group = Get_First_Entities(LUIS_Object);
                    }
                    else { Group = LUIS_Object.entities.First().type; }

                    string[] Group_Split1 = Group.Split(':', ':');

                    switch (Group_Split1[0])
                    {
                        case "軟體與作者介紹":
                            result_message = Introduction_Message.Self_Introduction(Group_Split1[2], br);
                            break;
                        case "學校介紹1":
                            if(Group_Split1[2].Contains("位置") || Group_Split1[2].Contains("在哪") || Group_Split1[2].Contains("在哪裡") || Group_Split1[2].Contains("怎麼走"))
                                RootDialog.Image_Use = 1;
                            result_message = Introduction_Message.School_Introduction(Group_Split1[2], br);
                            break;
                        case "學校介紹2":
                            result_message = Introduction_Message.School_Introduction(Group_Split1[2], br);
                            break;
                        case "學校介紹3":
                            result_message = Introduction_Message.School_Introduction(Group_Split1[2], br);
                            break;
                        case "學校公車介紹":
                            result_message = Introduction_Message.BUS_Introduction(Group_Split1[2], br);
                            break;
                        case "學校餐廳介紹":
                            result_message = Introduction_Message.Restaurant_Introduction(Group_Split1[2], br);
                            break;
                        case "行政單位介紹":
                            result_message = Introduction_Message.Administrative_Introduction(Group_Split1[2], br);
                            break;
                        case "學生權益1":
                            result_message = Student_Right_Message.Student_Right(Group_Split1[2], br);
                            break;
                        case "學生權益2":
                            result_message = Student_Right_Message.Student_Right(Group_Split1[2], br);
                            break;
                        case "各系介紹":
                            result_message = Department_Introduction_Message.Department_Introduction(Group_Split1[2], LUIS_Object.query, br);
                            break;
                        case "老師介紹":
                            result_message = Department_Introduction_Message.Department_Introduction(Group_Split1[2], LUIS_Object.query, br);
                            break;
                        case "Mall介紹":
                            result_message = Mall_Introduction_Message.Mall_Introduction(Group_Split1[2], br);
                            break;
                        case "新生":
                            result_message = New_Student_Message.New_Student(user_name, br);
                            break;
                    }
                    break;
                    
                case "諮詢":
                    if (LUIS_Object.entities.Length > 1)
                    {
                        Group = Get_First_Entities(LUIS_Object);
                    }
                    else { Group = LUIS_Object.entities.First().type; }

                    string[] Group_Split2 = Group.Split(':', ':');

                    switch (Group_Split2[0])
                    {
                        case "註冊組業務":
                            result_message = Question_Message.Registration_Section(Group_Split2[2], br);
                            break;
                        case "課務組業務1":
                            result_message = Question_Message.Curriculum_Section(Group_Split2[2], br);
                            break;
                        case "課務組業務2":
                            result_message = Question_Message.Curriculum_Section(Group_Split2[2], br);
                            break;
                        case "生輔組業務":
                            result_message = Question_Message.Life_Counseling_Section(Group_Split2[2], br);
                            break;
                        case "安全組業務":
                            result_message = Question_Message.Security_Section(Group_Split2[2], br);
                            break;
                        case "服教組業務":
                            result_message = Question_Message.Service_Education_Section(Group_Split2[2], br);
                            break;
                        case "軍訓室業務":
                            result_message = Question_Message.Military_Training_Room(Group_Split2[2], br);
                            break;
                        case "圖資處業務":
                            result_message = Question_Message.Information_Introduction(Group_Split2[2], br);
                            break;
                        case "學生住宿組業務":
                            result_message = Question_Message.Student_Accommodation_Section(Group_Split2[2], br);
                            break;
                        case "會計處業務":
                            result_message = Question_Message.Accounting_Section(Group_Split2[2], br);
                            break;
                        case "進修部":
                            result_message = Question_Message.Division_Of_Continuing_Education(Group_Split2[2], br);
                            break;
                        case "行政單位介紹":
                            result_message = Introduction_Message.Administrative_Introduction(Group_Split2[2], br);
                            break;
                        case "學校介紹1":
                            if (Group_Split2[2] == "國際學院" || Group_Split2[2] == "科技大樓" || Group_Split2[2] == "綜教大樓" || Group_Split2[2] == "理工大樓" || Group_Split2[2] == "行政大樓")
                                RootDialog.Image_Use = 1;
                            result_message = Introduction_Message.School_Introduction(Group_Split2[2], br);
                            break;
                        case "學校介紹2":
                            result_message = Introduction_Message.School_Introduction(Group_Split2[2], br);
                            break;
                        case "學校介紹3":
                            result_message = Introduction_Message.School_Introduction(Group_Split2[2], br);
                            break;
                        case "學校餐廳介紹":
                            if (LUIS_Object.query.Contains("菜單") && LUIS_Object.query.Contains("義咖啡"))
                            {
                                result_message = "以下為105-2的菜單，僅供參考，請以實際菜單為主";
                                RootDialog.Image_Use = 2;
                            }
                            else
                            { 
                            result_message = Introduction_Message.Restaurant_Introduction(Group_Split2[2], br);
                            }
                            break;
                        case "學校公車介紹":
                            result_message = Introduction_Message.BUS_Introduction(Group_Split2[2], br);
                            break;
                        case "學生權益1":
                            result_message = Student_Right_Message.Student_Right(Group_Split2[2], br);
                            break;
                        case "學生權益2":
                            result_message = Student_Right_Message.Student_Right(Group_Split2[2], br);
                            break;
                        case "各系介紹":
                            result_message = Department_Introduction_Message.Department_Introduction(Group_Split2[2], LUIS_Object.query, br);
                            break;
                        case "軟體與作者介紹":
                            result_message = Introduction_Message.Self_Introduction(Group_Split2[2], br);
                            break;
                        case "閒聊":
                            result_message = Talk_Message.Talk(Group_Split2[2], br);
                            if (Group_Split2[2] == "翹課")
                            {
                                Random rd = new Random(Guid.NewGuid().GetHashCode());
                                int rdm = rd.Next();
                                if (rdm % 2 == 0)
                                {
                                    result_message = result_message + br + "翹吧" + br + " (✪ω✪)";
                                }
                                else result_message = result_message + br + "乖乖上課" + br + " ლ(́◕◞౪◟◕‵ლ)";
                            }
                            break;
                        case "Mall介紹":
                            result_message = Mall_Introduction_Message.Mall_Introduction(Group_Split2[2], br);
                            break;
                        case "垃圾話":
                            result_message = "ლ(・ω・ლ)";
                            break;
                        case "新生":
                            result_message = New_Student_Message.New_Student(user_name, br);
                            break;
                    }
                    break;
            }
            return result_message;
        }

        private static string Get_First_Entities(LUISResponse Data)
        {
            int Length;
            int where = 0;
            double score;
            string entities;

            Length = Data.entities.Length;

            score = Data.entities[0].score;

            for (int i = 0; i <= Length - 1; i++)
            {
                if (i == Length)
                { }
                else if (Data.entities[i].score > score)
                {
                    score = Data.entities[i].score;
                    where = i;
                }
            }

            entities = Data.entities[where].type;

            return entities;
        }

    }
}