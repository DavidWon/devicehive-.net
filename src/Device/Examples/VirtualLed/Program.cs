using System;
using DeviceHive.Device;

namespace VirtualLed
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // initialize logger
                log4net.Config.XmlConfigurator.Configure();

                // create a RestfulDeviceService used to communicate with the DeviceHive cloud
                // insert your assigned DeviceHive service URL here
                using (var service = new RestfulDeviceService("http://192.168.1.112:8080/DeviceHiveJava/rest"))
                {
                    // create a DeviceHive network where our device will reside
                    var network = new Network("윤성환 iBlock2 담당 지역", "윤성환 관리자가 담당하고 있는 동대구 iblock 지역");

                    // create a DeviceHost used to run our device
                    var deviceHost = new DeviceHost(service, network);

                    // create an instance of virtual LED device and add it to the host
                    var led = new VirtualLedDevice();
                    deviceHost.AddDevice(led);

                    // start the host - it will register the device and start polling commands
                    deviceHost.Start();

                    // wait for console key press and then stop the host
                    Console.WriteLine("잉크알리미의 상태를 변경하려면 숫자를 입력하세요.");
                    Console.WriteLine("1 : 빨간색 잉크 부족");
                    Console.WriteLine("2 : 노란색 잉크 부족");
                    Console.WriteLine("3 : 파란색 잉크 부족");
                    Console.WriteLine("4 : 검정색 잉크 부족");
                    Console.WriteLine("잉크알리미를 종료하려면 q 를 눌러주세요.");

                    ConsoleKeyInfo keyInfo;
                    do
                    {
                        keyInfo = Console.ReadKey();
                        int state = 0;
                        switch (Char.ToLower(keyInfo.KeyChar))
                        {
                            case '1':
                                Console.WriteLine("  빨간색 잉크가 부족합니다.");
                                state = 1;
                                break;
                            case '2': 
                                Console.WriteLine("  노란색 잉크가 부족합니다.");
                                state = 2;
                                break;
                            case '3': 
                                Console.WriteLine("  파란색 잉크가 부족합니다.");
                                state = 4;
                                break;
                            case '4': 
                                Console.WriteLine("  검정색 잉크가 부족합니다.");
                                state = 8;
                                break;
                            case '5':
                                Console.WriteLine("  잉크교체가 완료 되었습니다.");
                                state = 9;
                                break;
                        }
                        
                        led.UpdateLedState(state);
                        

                    } while (Char.ToLower(keyInfo.KeyChar) != 'q');

                    // Console.ReadKey();
                    deviceHost.Stop();
                }
            }
            catch (Exception ex)
            {
                // handle the error
                Console.WriteLine("에러 Error: " + ex);
                Console.ReadKey();
            }
        }
    }
}
