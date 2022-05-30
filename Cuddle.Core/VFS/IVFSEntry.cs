using Cuddle.Core.Assets;
using Microsoft.Toolkit.HighPerformance.Buffers;

namespace Cuddle.Core.VFS;

public interface IVFSEntry : IPoliteDisposable {
    IVFSFile Owner { get; }
    long Size { get; }
    string MountedPath { get; }
    string ObjectPath { get; }
    ulong MountedHash { get; }
    IPoliteDisposable? Data { get; set; }
    MemoryOwner<byte> ReadFile();
    UAssetFile? ReadAsset();
    UObject? ReadAssetExport(int index);
    UObject?[] ReadAssetExports();
}