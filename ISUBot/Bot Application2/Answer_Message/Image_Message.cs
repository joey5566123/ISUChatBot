using Microsoft.Bot.Connector;
using System.Collections.Generic;

namespace Bot_Application2.Answer_Message
{
    public class Image_Message
    {
        public static string ContentUrl { get; private set; }

        public static IMessageActivity ISU_Map(IMessageActivity ima)
        {
            ima.Attachments.Add(new Attachment()
            {
                ContentUrl = "http://i.imgur.com/KPAwGRB.jpg",
                ContentType = "image/jpg",
                Name = "map.jpg"
            });
            return ima;
        }

        public static IMessageActivity ISU_Coffee_Map(IMessageActivity ima)
        {
            ima.Attachments = new List<Attachment>
            {
                new Attachment()
                {
                    ContentUrl = "http://i.imgur.com/Aq3wFIq.jpg",
                    ContentType = "image/jpg",
                    Name = "menu1.jpg"
                },
                new Attachment()
                {
                    ContentUrl = "http://i.imgur.com/Zmy1Tfl.jpg",
                    ContentType = "image/jpg",
                    Name = "menu2.jpg"
                },
                new Attachment()
                {
                    ContentUrl = "http://i.imgur.com/6rVybfb.jpg",
                    ContentType = "image/jpg",
                    Name = "menu3.jpg"
                },
                new Attachment()
                {
                    ContentUrl = "http://i.imgur.com/eJeFkB7.jpg",
                    ContentType = "image/jpg",
                    Name = "menu4.jpg"
                }
            };

            return ima;
        }

        public static IMessageActivity ISU_Dog(IMessageActivity ima)
        {
            ima.Attachments.Add(new Attachment()
            {
                ContentUrl = "https://scontent-tpe1-1.xx.fbcdn.net/v/t1.0-9/18835572_375459332849264_8058280334008072850_n.jpg?oh=d1c6656b8d7fd3a5a27d75e8cea828a7&oe=59DCE5B4",
                ContentType = "image/jpg",
                Name = "map.jpg"
                
            });
            return ima;
        }

        public static IMessageActivity Expression(IMessageActivity ima)
        {
            ima.Value = "\"sender_action\":\"typing_on\"";
            ima.Text = "\"sender_action\":\"typing_on\"";
            return ima;
        }


    }
}