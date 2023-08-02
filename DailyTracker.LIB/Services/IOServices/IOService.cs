namespace DailyTracker.LIB.Services.IOServices;

public abstract class IOService<TObject>
{
    protected string DirectoryLocation { get; set; }

    protected string FileName { get; set; } = string.Empty;

    protected string FilePath => Path.Combine(DirectoryLocation, FileName);

    public IOService(string directoryPath)
    {
        if (Directory.Exists(directoryPath) == false)
            throw new DirectoryNotFoundException();

        DirectoryLocation = directoryPath;
    }

    public abstract TObject? Read();

    public abstract void Write(TObject? data);
}