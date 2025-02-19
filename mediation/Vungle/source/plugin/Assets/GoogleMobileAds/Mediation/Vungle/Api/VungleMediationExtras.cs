// Copyright 2017 Google LLC
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

using System;
using System.Collections.Generic;

namespace GoogleMobileAds.Mediation.Vungle.Api
{
    public abstract class VungleMediationExtras : MediationExtras
    {
        public const string AllPlacementsKey = "all_placements";

        public const string UserIdKey = "user_id";

        public const string SoundEnabledKey = "sound_enabled";

        public VungleMediationExtras() : base() { }

        public override string IOSMediationExtraBuilderClassName
        {
            get { return "VungleExtrasBuilder"; }
        }

        public void SetAllPlacements(string[] allPlacements)
        {
            this.Extras.Add(AllPlacementsKey, String.Join(",", allPlacements));
        }

        public void SetUserId(string userId)
        {
            this.Extras.Add(UserIdKey, userId);
        }

        public void SetSoundEnabled(bool soundEnabled)
        {
            this.Extras.Add(SoundEnabledKey, soundEnabled.ToString());
        }
    }
}


namespace GoogleMobileAds.Api.Mediation.Vungle
{
    [System.Obsolete("Use `GoogleMobileAds.Mediation.Vungle.Api.VungleMediationExtras` instead.")]
    public abstract class VungleMediationExtras :
                          GoogleMobileAds.Mediation.Vungle.Api.VungleMediationExtras
    {
    }
}
