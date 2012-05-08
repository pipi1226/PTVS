﻿/* ****************************************************************************
 *
 * Copyright (c) Microsoft Corporation. 
 *
 * This source code is subject to terms and conditions of the Apache License, Version 2.0. A 
 * copy of the license can be found in the License.html file at the root of this distribution. If 
 * you cannot locate the Apache License, Version 2.0, please send an email to 
 * vspython@microsoft.com. By using this source code in any fashion, you are agreeing to be bound 
 * by the terms of the Apache License, Version 2.0.
 *
 * You must not remove this notice, or any other, from this software.
 *
 * ***************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.PythonTools.Project;
using Microsoft.VisualStudio.Shell.Interop;
using Microsoft.VisualStudio;

namespace Microsoft.PythonTools.Django.Project {
    class DjangoAzureSolutionListener : SolutionListener {
        public readonly List<IVsHierarchy> OpenedHierarchies = new List<IVsHierarchy>();
        public DjangoAzureSolutionListener(IServiceProvider serviceProvider)
            : base(serviceProvider) {
        }

        public override int OnAfterOpenProject(IVsHierarchy hierarchy, int added) {
            if (added != 0) {
                OpenedHierarchies.Add(hierarchy);
            }
            return VSConstants.E_NOTIMPL;
        }
    }
}
