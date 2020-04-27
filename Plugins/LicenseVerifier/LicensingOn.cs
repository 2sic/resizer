// Copyright (c) Imazen LLC.
// No part of this project, including this file, may be copied, modified,
// propagated, or distributed except as permitted in COPYRIGHT.txt.
// Licensed under the GNU Affero General Public License, Version 3.0.
// Commercial licenses available at http://imageresizing.net/

namespace ImageResizer.Plugins.LicenseVerifier
{
    partial class LicenseEnforcer<T>
    {
        // disabled to use as AGPL module without the dot, as discussed w/Jonathan
        // See previous code https://github.com/2sic/resizer/commit/33735dbc7c77cb9d0746f52a8b382965c786fa44
        const bool Enforce = false;// true;
    }
}
