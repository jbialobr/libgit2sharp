﻿namespace LibGit2Sharp.Core.Handles
{
    internal class ObjectDatabaseSafeHandle : SafeHandleBase
    {
        protected override bool InternalReleaseHandle()
        {
            Proxy.git_odb_free(handle);
            return true;
        }
    }
}
