using Impact_project.Models;
using Impact_project.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Impact_project.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Service> services = new List<Service>()
            {
           new Service()
            {
                Title = "Digital Marketinq",
                Description = "Onlayn marketinq olaraq da adlandırılan Digital Marketinq potensial alıcı ilə əlaqə qura bilmək üçün internet və digər rəqəmsal kommunikasiya (rabitə) metodlarından istifadə edərək marketinq fəalliyyətini həyata keçirmə prosesidir. ",
                IconName = "bi bi-activity",
                Url = "https://code.edu.az",
                UrlText = "Daha ətraflı"
            },
            new Service()
            {
                Title = "Dizayn",
                Description = "Dizayn brend və hədəf auditoriyası arasındakı vizual ünsiyyət əhatə edən bir sahədir. İndividuallığa ehtiyacın bu qədər artdığı bir dövrdə qrafik, interior, exterior dizayn və hərəkətli qrafika kimi sahələr olduqca tələbat görür.",
                IconName = "bi bi-broadcast",
                Url = "https://code.edu.az",
                UrlText = "Daha ətraflı"
            },
            new Service()
            {
                Title = "It və Təhlükəsizlik",
                Description = "IT və Kiber Təhlükəsizlik həyatımızın hər hissəsində qarşılaşdığımız sahələrdəndir. İnformasiya sistemlərinin və texnologiyalarının müasir dövrümüzdə rolunu nəzərə alsaq, bu sahənin inkişafı və yaranacaq mütəxəssis ehtiyacı qaçılmazdır.",
                IconName = "bi bi-easel",
                Url = "https://code.edu.az",
                UrlText = "Daha ətraflı"
            },
            new Service()
            {
                Title = "Proqramlaşdırma",
                Description = "Proqramlaşdırma müəyyən bir nəticəni əldə etmək və ya vəzifəni yerinə yetirmək üçün komputerə verilən icralar toplusudur. Sahə proqramlaşdırma dillərindən istifadə edərək alqortimlərin müəyyən edilməsi və tətbiqi kimi işləri özündə əhatə edir. Ümumilikdə, proqram yaratmaqla bağlı nəzəri və praktiki yaradıcılıq sahəsi proqramlaşdırmanın izahını tam olaraq əhatə edir. ",
                IconName = "bi bi-bounding-box-circles",
                Url = "https://code.edu.az",
                UrlText = "Daha ətraflı"
            },
            new Service()
            {
                Title = "Full stack back-end",
                Description = "C# proqramlaşdırma dili üzərində qurulub və alqoritimlərin əsasları məhz bu dil üzərindən tədris olunur. Verilənlər bazası olaraq MS SQL Server (SQL dili) sistemindən istifadə edilir. Backend proqramlaşdırmanın əsasları müasir texnologiya olan .NET Core framework-ü ilə bəhs edilir. Əlavə olaraq final layihəsi idarəedilməsində DevOps (GitHub, Docker, RabbitMQ) texnologiyasından istifadə edilir. ",
                IconName = "bi bi-calendar4-week",
                Url = "https://code.edu.az",
                UrlText = "Daha ətraflı"
            },
            new Service()
            {
                Title = "Full stack front-end",
                Description = " Tədris proqramı həm yerli, həm də beynəlxalq təşkilatların istifadə etdiyi texnologiyaları özündə birləşdirir. Belə ki, front-end tədrisinin başlanğıcında HTML, CSS, JavaScript dilləri, daha sonra verilənlər bazası olaraq MongoDB sistemi izah edilir.Əlavə olaraq, full stack ağırlıqlı tədris olduğuna görə back-end texnologiyaları və onların inteqrasiyasını icra edən React, Node.js, Next.js, TypeSxript tədris edilir. ",
                IconName = "bi bi-chat-square-text",
                Url = "https://code.edu.az",
                UrlText = "Daha ətraflı"
            }

        };

             List<Testimonials> testimonials = new List<Testimonials>()
            {
           new Testimonials()
            {
                ImagePath = "/assets/img/testimonials/testimonials-1.jpg",
                Name = "Seymur Əliyev",
                Position = "Ceo&Founder",
                Description = "Linkə keçid edin",
            },
             new Testimonials()
            {
                ImagePath = "/assets/img/testimonials/testimonials-2.jpg",
                Name = "Leyla Əliyeva",
                Position = "Designer",
                Description = "Linkə keçid edin",
            },
               new Testimonials()
            {
                ImagePath = "/assets/img/testimonials/testimonials-3.jpg",
                Name = "Lalə Orucova",
                Position = "Store-Owner",
                Description = "Linkə keçid edin",
            },
                 new Testimonials()
            {
                ImagePath = "/assets/img/testimonials/testimonials-4.jpg",
                Name = "Onur Əliyev",
                Position = "Freelancer",
                Description = "Linkə keçid edin",
            },
                   new Testimonials()
            {
                ImagePath = "/assets/img/testimonials/testimonials-5.jpg",
                Name = "Elxan Məmmədli",
                Position = "Entrepeneur",
                Description = "Linkə keçid edin",
            },

        };


            HomeViewModel viewModel = new HomeViewModel()
            {
                Services = services,
                Testimonials = testimonials
            };

            return View(viewModel);
        }
    }
}
