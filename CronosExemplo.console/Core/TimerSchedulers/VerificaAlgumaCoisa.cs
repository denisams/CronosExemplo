using CronosExemplo.console.Core.Extensions;
using Microsoft.Extensions.DependencyInjection;

namespace CronosExemplo.console.Core.TimerSchedulers
{
    public class VerificaAlgumaCoisa : CronJobExtensions
    {
        public VerificaAlgumaCoisa(IScheduleConfig<VerificaAlgumaCoisa> config, IServiceProvider serviceProvider)
            : base(config.CronExpression, config.TimeZoneInfo, serviceProvider)
        {
        }

        public override Task DoWork(IServiceScope scope, CancellationToken cancellationToken)
        {
            Serilog.Log.Information("Faz alguma coisa, ou verificação");
            return Task.CompletedTask;
        }
    }
}
