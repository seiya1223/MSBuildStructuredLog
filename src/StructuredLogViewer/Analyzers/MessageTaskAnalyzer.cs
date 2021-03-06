﻿using System.Linq;

namespace Microsoft.Build.Logging.StructuredLogger
{
    public class MessageTaskAnalyzer
    {
        public static void Analyze(Task task)
        {
            var message = task.Children.OfType<Message>().SingleOrDefault();
            if (message != null && message.ShortenedText != null)
            {
                task.Title = "Message: " + message.ShortenedText;
            }
        }
    }
}
