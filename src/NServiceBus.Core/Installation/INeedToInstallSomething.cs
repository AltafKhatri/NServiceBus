namespace NServiceBus.Installation
{
    /// <summary>
    /// Interface invoked by the infrastructure when going to install an endpoint.
    /// Implementors should not implement this type directly but rather the generic version of it.
    /// </summary>
    public interface INeedToInstallSomething
    {
        /// <summary>
        /// Performs the installation providing permission for the given user.
        /// </summary>
        /// <param name="identity">The user for whom permissions will be given.</param>
        /// <param name="config"></param>
        void Install(string identity,Configure config);
    }

    /// <summary>
    /// Interface invoked by the infrastructure when going to install an endpoint for a specific environment.
    /// </summary>
    /// <typeparam name="T">The environment type.</typeparam>
    public interface INeedToInstallSomething<T> : INeedToInstallSomething where T : IEnvironment
    {
        
    }
}
