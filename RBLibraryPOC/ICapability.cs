using System;

public interface ICapability
{

    bool IsSupported(string resourcePath);

    bool IsSupported(IEdmModel model, ODataPath path);

    CapabilityType GetType();
}
