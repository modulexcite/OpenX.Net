﻿#region license
// Copyright (c) 2009 Mauricio Scheffer
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//      http://www.apache.org/licenses/LICENSE-2.0
//  
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
#endregion

using System;
using MbUnit.Framework;

namespace OpenXNet.Tests {
    [TestFixture]
    public class ManagerStatsTests : BaseSessionTests {
        [Test]
        public void ManagerAdvertiserStatistics() {
            using (var session = NewSession()) {
                var r = session.GetManagerAdvertiserStatistics(1, DateTime.Now.AddYears(-1), DateTime.Now);
                Console.WriteLine(r.Length);
            }
        }

        [Test]
        public void ManagerBannerStatistics() {
            using (var session = NewSession()) {
                var r = session.GetManagerBannerStatistics(1, DateTime.Now.AddYears(-1), DateTime.Now);
                Console.WriteLine(r.Length);
            }
        }

        [Test]
        public void ManagerCampaignStatistics() {
            using (var session = NewSession()) {
                var r = session.GetManagerCampaignStatistics(1, DateTime.Now.AddYears(-1), DateTime.Now);
                Console.WriteLine(r.Length);
            }
        }

        [Test]
        public void ManagerDailyStatistics() {
            using (var session = NewSession()) {
                var r = session.GetManagerDailyStatistics(1, DateTime.Now.AddYears(-1), DateTime.Now);
                Console.WriteLine(r.Length);
            }
        }

        [Test]
        public void ManagerPublisherStatistics() {
            using (var session = NewSession()) {
                var r = session.GetManagerPublisherStatistics(1, DateTime.Now.AddYears(-1), DateTime.Now);
                Console.WriteLine(r.Length);
            }
        }

        [Test]
        public void ManagerZoneStatistics() {
            using (var session = NewSession()) {
                var r = session.GetManagerZoneStatistics(1, DateTime.Now.AddYears(-1), DateTime.Now);
                Console.WriteLine(r.Length);
            }
        }
    }
}