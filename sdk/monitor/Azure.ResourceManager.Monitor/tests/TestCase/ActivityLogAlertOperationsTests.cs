﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Monitor.Models;
using Azure.ResourceManager.Monitor.Tests;
using NUnit.Framework;

namespace Azure.ResourceManager.Monitor.Tests.TestCase
{
    public class ActivityLogAlertOperationsTests : MonitorTestBase
    {
        public ActivityLogAlertOperationsTests(bool isAsync)
            : base(isAsync, RecordedTestMode.Record)
        {
        }

        private async Task<ActivityLogAlert> CreateActivityLogAlertAsync(string activityLogAlertName)
        {
            var collection = (await CreateResourceGroupAsync()).GetActivityLogAlerts();
            var subID = DefaultSubscription.Id;
            var input = ResourceDataHelper.GetBasicActivityLogAlertData("Global", subID);
            var lro = await collection.CreateOrUpdateAsync(activityLogAlertName, input);
            return lro.Value;
        }

        [TestCase]
        [RecordedTest]
        public async Task Delete()
        {
            var activityLogAlertName = Recording.GenerateAssetName("testActivityLogAlert-");
            var ActivityLogAlert = await CreateActivityLogAlertAsync(activityLogAlertName);
            await ActivityLogAlert.DeleteAsync();
        }

        [TestCase]
        [RecordedTest]
        public async Task Get()
        {
            var activityLogAlertName = Recording.GenerateAssetName("testActivityLogAlert-");
            var activityLogAlert = await CreateActivityLogAlertAsync(activityLogAlertName);
            ActivityLogAlert activityLogAlert2 = await activityLogAlert.GetAsync();
            ResourceDataHelper.AssertActivityLogAlert(activityLogAlert.Data, activityLogAlert2.Data);
        }
    }
}
