using System.Collections.Generic;
using System.IO;
using System.Net.Mail;
using System.Threading.Tasks;

public interface IEmailSender
{
    string ActionName { get; set; }
    string Attachment { get; set; }
    AttachmentCollection Attachments { get; set; }
    string Description { get; set; }
    string ImageURL { get; set; }
    List<string> SendBCC { get; set; }
    List<string> SendCC { get; set; }
    List<string> Sendto { get; set; }
    string Subject { get; set; }
    string SystemURL { get; set; }
    string AdminUrl { get; set; }
    string ToName { get; set; }
    string URL { get; set; }
    string WebUrl { get; set; }
    
    string GetUploadPath(string filename);
    Task SendEmail(bool SendAndWait = false);
}