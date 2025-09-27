namespace Microsoft.DevTunnels.Ssh;

/// <summary>
/// Expose manual window size increase function via interface.
/// </summary>
public interface IWindowingChannel
{
	/// <summary>
	/// Message the channel to increase the window size by a set amount.
	/// </summary>
	/// <param name="increment">The amount to increase the windowing size by.</param>
	void IncreaseWindowSize(uint increment);
}