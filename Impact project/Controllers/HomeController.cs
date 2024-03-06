using Impact_project.Models;
using Impact_project.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Impact_project.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Service> services = new List<Service>();
            
                Service S1 = new Service()
                        {
                           Title = "Digital Marketinq",
                           Description = "Onlayn marketinq olaraq da adlandırılan Digital Marketinq potensial alıcı ilə əlaqə qura bilmək üçün internet və digər rəqəmsal kommunikasiya (rabitə) metodlarından istifadə edərək marketinq fəalliyyətini həyata keçirmə prosesidir. ",
                           IconName = "bi bi-activity",
                           Url = "https://code.edu.az",
                           UrlText = "Daha ətraflı"
                        };
           Service S2 = new Service()
                        {
                           Title = "Dizayn",
                           Description = "Dizayn brend və hədəf auditoriyası arasındakı vizual ünsiyyət əhatə edən bir sahədir. İndividuallığa ehtiyacın bu qədər artdığı bir dövrdə qrafik, interior, exterior dizayn və hərəkətli qrafika kimi sahələr olduqca tələbat görür.",
                           IconName = "bi bi-broadcast",
                           Url = "https://code.edu.az",
                           UrlText = "Daha ətraflı"
                        };
           Service S3 = new Service()
                        {
                           Title = "It və Təhlükəsizlik",
                           Description = "IT və Kiber Təhlükəsizlik həyatımızın hər hissəsində qarşılaşdığımız sahələrdəndir. İnformasiya sistemlərinin və texnologiyalarının müasir dövrümüzdə rolunu nəzərə alsaq, bu sahənin inkişafı və yaranacaq mütəxəssis ehtiyacı qaçılmazdır.",
                           IconName = "bi bi-easel",
                           Url = "https://code.edu.az",
                           UrlText = "Daha ətraflı"
                        };
           Service S4 = new Service()
                        {
                           Title = "Proqramlaşdırma",
                           Description = "Proqramlaşdırma müəyyən bir nəticəni əldə etmək və ya vəzifəni yerinə yetirmək üçün komputerə verilən icralar toplusudur. Sahə proqramlaşdırma dillərindən istifadə edərək alqortimlərin müəyyən edilməsi və tətbiqi kimi işləri özündə əhatə edir. Ümumilikdə, proqram yaratmaqla bağlı nəzəri və praktiki yaradıcılıq sahəsi proqramlaşdırmanın izahını tam olaraq əhatə edir. ",
                           IconName = "bi bi-bounding-box-circles",
                           Url = "https://code.edu.az",
                           UrlText = "Daha ətraflı"
                        };
           Service S5 = new Service()
                        {
                            Title = "Full stack back-end",
                            Description = "C# proqramlaşdırma dili üzərində qurulub və alqoritimlərin əsasları məhz bu dil üzərindən tədris olunur. Verilənlər bazası olaraq MS SQL Server (SQL dili) sistemindən istifadə edilir. Backend proqramlaşdırmanın əsasları müasir texnologiya olan .NET Core framework-ü ilə bəhs edilir. Əlavə olaraq final layihəsi idarəedilməsində DevOps (GitHub, Docker, RabbitMQ) texnologiyasından istifadə edilir. ",
                            IconName = "bi bi-calendar4-week",
                            Url = "https://code.edu.az",
                            UrlText = "Daha ətraflı"
                        };
           Service S6 = new Service()
                        {
                            Title = "Full stack front-end",
                            Description = " Tədris proqramı həm yerli, həm də beynəlxalq təşkilatların istifadə etdiyi texnologiyaları özündə birləşdirir. Belə ki, front-end tədrisinin başlanğıcında HTML, CSS, JavaScript dilləri, daha sonra verilənlər bazası olaraq MongoDB sistemi izah edilir.Əlavə olaraq, full stack ağırlıqlı tədris olduğuna görə back-end texnologiyaları və onların inteqrasiyasını icra edən React, Node.js, Next.js, TypeSxript tədris edilir. ",
                            IconName = "bi bi-chat-square-text",
                            Url = "https://code.edu.az",
                            UrlText = "Daha ətraflı"
                        };


                        services.Add(S1);
                        services.Add(S2);
                        services.Add(S3);
                        services.Add(S4);
                        services.Add(S5);
                        services.Add(S6);

                    HomeViewModel viewModel = new HomeViewModel()
                    {
                        Services = services
                    };

                    return View(viewModel);
        }
    }
}
