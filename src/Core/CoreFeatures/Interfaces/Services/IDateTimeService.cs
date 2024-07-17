using System;

namespace Core.CoreFeatures.Interfaces.Services;

public interface IDateTimeService
{
    DateTime NowUtc { get; }
}