using System;
using System.Threading.Tasks;
using WaterQualityMonitor.Models;

namespace WaterQualityMonitor.Services
{
    public interface IMonitoringService
    {
        event Action<SensorData> SensorDataReceived;
        void StartMonitoring();
    }    


    public class MonitoringService : IMonitoringService
    {
        private readonly ISensorService _sensorService;
        private readonly IFileService _fileService;

        public event Action<SensorData> SensorDataReceived;

        public MonitoringService(ISensorService sensorService, IFileService fileService)
        {
            _sensorService = sensorService;
            _fileService = fileService;
        }

        public async void StartMonitoring()
        {
            while (true)
            {
                SensorData data = await _sensorService.GetSensorDataAsync();

                // 구독함수 호출
                SensorDataReceived?.Invoke(data);
                
                // 파일 저장
                await _fileService.SaveDataAsync(data);

                // 대기 
                await Task.Delay(10*1000); // 10초 대기
            }
        }
    }
}
