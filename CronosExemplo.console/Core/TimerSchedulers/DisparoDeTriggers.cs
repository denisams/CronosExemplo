using CronosExemplo.console.Core.Extensions;
using Microsoft.Extensions.DependencyInjection;

namespace CronosExemplo.console.Core.TimerSchedulers
{
    public class DisparoDeTriggers : CronJobExtensions
    {
        public DisparoDeTriggers(IScheduleConfig<DisparoDeTriggers> config, IServiceProvider serviceProvider)
            : base(config.CronExpression, config.TimeZoneInfo, serviceProvider)
        {
        }

        public override Task DoWork(IServiceScope scope, CancellationToken cancellationToken)
        {
            Serilog.Log.Information("Dispara uma trigger depois de alguma verificação!");
            return Task.CompletedTask;
        }
    }
}
