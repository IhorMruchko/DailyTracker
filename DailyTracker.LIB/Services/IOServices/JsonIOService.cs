﻿using Newtonsoft.Json;

namespace DailyTracker.LIB.Services.IOServices;

public class JsonIOService<TObject> : IOService<TObject>
{
    public JsonIOService(string directoryPath, string fileName) : base(directoryPath)
    {
        FileName = fileName;

        if (Path.GetExtension(FilePath) != ".json")
            throw new FileLoadException();

        if (File.Exists(FilePath) == false)
            File.Create(FilePath);
    }

    public override TObject? Read()
        => JsonConvert.DeserializeObject<TObject?>(File.ReadAllText(FilePath)) ?? throw new NullReferenceException();

    public override void Write(TObject? data)
        => File.WriteAllText(FilePath, JsonConvert.SerializeObject(data, Formatting.Indented));
}
