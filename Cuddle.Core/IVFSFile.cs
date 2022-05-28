﻿using System;
using System.Collections.Generic;
using Cuddle.Core.Enums;
using Microsoft.Toolkit.HighPerformance.Buffers;

namespace Cuddle.Core;

public interface IVFSFile {
    string Name { get; }
    EGame Game { get; }
    Guid EncryptionGuid { get; }
    byte[]? EncryptionKey { get; set; }
    bool HasHashes { get; }
    bool HasPaths { get; }
    IEnumerable<IVFSEntry> Entries { get; }
    MemoryOwner<byte> ReadFile(string path);
    MemoryOwner<byte> ReadFile(ulong hash);
    MemoryOwner<byte> ReadFile(IVFSEntry entry);
    UObject? ReadAssetExport(string path, int export);
    UObject? ReadAssetExport(ulong hash, int export);
    UObject? ReadAssetExport(IVFSEntry entry, int export);
    UObject?[] ReadAssetExports(string path);
    UObject?[] ReadAssetExports(ulong hash);
    UObject?[] ReadAssetExports(IVFSEntry entry);
    bool FindEncryptionKey(AESKeyStore aesKey, MemoryOwner<byte> test);
}
