using CommunityToolkit.Mvvm.ComponentModel;
using WaterQualityMonitor.Models;
using WaterQualityMonitor.Services;

namespace WaterQualityMonitor.ViewModels
{
    public partial class MainWindowViewModel : ObservableObject
    {
        // 서비스 Layer
        private readonly IMonitoringService _monitoringService;

        // Data Model 
        [ObservableProperty]
        private SensorData sensorData = new SensorData();



        public MainWindowViewModel(IMonitoringService monitoringService)
        {
            _monitoringService = monitoringService;
            _monitoringService.SensorDataReceived += OnSensorDataReceived;
            _monitoringService.StartMonitoring();
        }

        private void OnSensorDataReceived(SensorData data)
        {
            SensorData = data; // UI 자동 갱신
        }
    }
}
