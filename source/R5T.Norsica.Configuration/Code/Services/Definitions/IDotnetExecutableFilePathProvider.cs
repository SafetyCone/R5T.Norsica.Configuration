using System;

using R5T.T0064;


namespace R5T.Norsica.Configuration
{
    [ServiceDefinitionMarker]
    public interface IDotnetExecutableFilePathProvider : IServiceDefinition
    {
        string GetDotnetExecutableFilePath();
    }
}
