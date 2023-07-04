﻿using LibHac.Tools.FsSystem.NcaUtils;

namespace EmmcHaccGen.nca
{
    class VersionExtractor
    {
        public NcaFile versionMetaNca;
        private TitleVersion ExtractedVersion
        {
            get
            {
                return versionMetaNca.cnmt.TitleVersion;
            }
        }
        public string Version
        {
            get
            {
                return $"{ExtractedVersion.Major}.{ExtractedVersion.Minor}.{ExtractedVersion.Patch}";
            }
        }

        public bool UseV5Save()
        {
            return (ExtractedVersion.Major >= 5);
        }

        public VersionExtractor() { }
        public VersionExtractor(NcaFile nca)
        {
            versionMetaNca = nca;
        }
    }
}
