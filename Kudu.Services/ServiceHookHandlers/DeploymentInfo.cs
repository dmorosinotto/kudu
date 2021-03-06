﻿using System;
using Kudu.Core.SourceControl;

namespace Kudu.Services.ServiceHookHandlers
{
    public class DeploymentInfo
    {
        public DeploymentInfo()
        {
            IsReusable = true;
        }

        public RepositoryType RepositoryType { get; set; }
        public string RepositoryUrl { get; set; }
        public string Deployer { get; set; }
        public ChangeSet TargetChangeset { get; set; }
        public bool IsReusable { get; set; }
        // indicating that this is a CI triggered by SCM provider 
        public bool IsContinuous { get; set; }
        public IServiceHookHandler Handler { get; set; }

        public bool IsValid()
        {
            return !String.IsNullOrEmpty(Deployer);
        }
    }
}