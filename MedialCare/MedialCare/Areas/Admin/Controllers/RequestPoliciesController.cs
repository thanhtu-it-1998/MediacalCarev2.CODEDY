using MedialCare.Areas.Account.Controllers;
using MedialCare.Areas.Admin.Models.Common;
using MedialCare.Components;
using MedialCare.Models.EF;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using MedialCare.Models.Data.Entities;

namespace MedialCare.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class RequestPoliciesController : CheckAccountController
    {
        public readonly ApplicationDbContext _context;
        public RequestPoliciesController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var query = (from r in _context.RequestPolicies
                         join p in _context.Policys on r.PolicyID equals p.ID
                         join c in _context.Companys on p.CompanyId equals c.ID
                         join u in _context.Users on r.UserID equals u.ID
                         select new { c, p, r, u });

            var res = query.Select(x => new RequestPoliciesModel
            {
                ID = x.r.ID,
                Company = x.c.Name,
                Policies = x.p.Name,
                User = x.u.Username,
                Date = x.r.CreatedAt,
                Status = x.r.Status
            }).ToList();

            return View(res);
        }
        public IActionResult Delete(int ID)
        {
            if (ID == null)
            {
                return NotFound();
            }

            var feedback = _context.RequestPolicies
                .FirstOrDefault(m => m.ID == ID);
            if (feedback == null)
            {
                return NotFound();
            }
            _context.RequestPolicies.Remove(feedback);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        
        public IActionResult ChangeStatus(int ID)
        {
            var res = _context.RequestPolicies.Where(x => x.ID == ID).FirstOrDefault();
            res.Status = MedialCare.Models.Enum.Status.Approval;
            _context.Entry(res).State = EntityState.Modified;
            _context.SaveChanges();

            if (!ModelState.IsValid) return RedirectToAction("Index");
            //try
            //{
            //    MailMessage mail = new MailMessage();
            //    mail.From = new MailAddress("phamtuancules20@gmail.com");
            //    mail.To.Add("tuanpth1908045@fpt.edu.vn");
            //    mail.IsBodyHtml = true;
            //    string content = "Name: " + emailFormModel.FromName;
            //    content += "</br> Message: " + emailFormModel.Message;

            //    mail.Body = content;

            //    SmtpClient smtpClient = new SmtpClient("abc.simax.com");
            //    NetworkCredential netWorkCredential = new NetworkCredential("phamtuancules20@gmail.com", "Pham30052017@");
            //    smtpClient.UseDefaultCredentials = false;
            //    smtpClient.Credentials = netWorkCredential;
            //    smtpClient.Port = 25;
            //    smtpClient.EnableSsl = false;
            //    smtpClient.Send(mail);

            //    ViewBag.Message = "Mail Send";
            //    ModelState.Clear();
            //}
            try
            {
                //EmailFormModel emailform = new EmailFormModel();
                string to = "nguyenhoangminh26a@gmail.com";
                string subject = "Tuan test mail";
                string body = "Hello World!";

                MailMessage mail = new MailMessage();
                mail.To.Add(to);
                mail.Subject = subject;
                mail.Body = body;
                mail.From = new MailAddress("tuan20pham@gmail.com");
                mail.IsBodyHtml = false;

                SmtpClient smtp = new SmtpClient("smtp.gmail.com");

                NetworkCredential networkCredential = new NetworkCredential("tuan20pham@gmail.com", "Tuan30052017@");

                smtp.Port = 587;
                smtp.UseDefaultCredentials = false;
                smtp.EnableSsl = true;
                smtp.Credentials = networkCredential;
                smtp.Send(mail);
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message.ToString();
            }
            return RedirectToAction("Index");

        }
    }
}
