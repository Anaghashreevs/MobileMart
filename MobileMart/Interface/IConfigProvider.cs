using MobileMart.Enums;

namespace MobileMart.Interface
{
    public interface IConfigProvider
    {
        public static ConfigType ConfigEnum;
        public void GetConfigDetails(ConfigType configType);

    }
}
