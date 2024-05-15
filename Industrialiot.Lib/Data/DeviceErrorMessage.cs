﻿namespace Industrialiot.Lib.Data
{
    internal class DeviceErrorMessage
    {
        public DeviceError deviceError {  get; set; }
        public uint newErrorsCount { get; set; }

        public DeviceErrorMessage(DeviceError deviceError, uint newErrorsCount)
        {
            this.deviceError = deviceError;
            this.newErrorsCount = newErrorsCount;
        }
    }
}
