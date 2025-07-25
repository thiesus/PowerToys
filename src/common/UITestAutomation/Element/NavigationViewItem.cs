﻿// Copyright (c) Microsoft Corporation
// The Microsoft Corporation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Microsoft.PowerToys.UITest
{
    /// <summary>
    /// Represents a NavigationViewItem in the UI test environment.
    /// NavigationViewItem represents the container for an item in a NavigationView control.
    /// </summary>
    public class NavigationViewItem : Element
    {
        private static readonly string ExpectedControlType = "ControlType.ListItem";

        /// <summary>
        /// Initializes a new instance of the <see cref="NavigationViewItem"/> class.
        /// </summary>
        public NavigationViewItem()
        {
            this.TargetControlType = NavigationViewItem.ExpectedControlType;
        }

        /// <summary>
        /// Click the ListItem element.
        /// </summary>
        /// <param name="rightClick">If true, performs a right-click; otherwise, performs a left-click. Default value is false</param>
        /// <param name="msPreAction">Pre action delay in milliseconds. Default value is 500</param>
        /// <param name="msPostAction">Post action delay in milliseconds. Default value is 500</param>
        public override void Click(bool rightClick = false, int msPreAction = 500, int msPostAction = 500)
        {
            PerformAction(
                (actions, windowElement) =>
            {
                actions.MoveToElement(windowElement, 10, 10);

                if (rightClick)
                {
                    actions.ContextClick();
                }
                else
                {
                    actions.Click();
                }

                actions.Build().Perform();
            },
                msPreAction,
                msPostAction);
        }

        /// <summary>
        /// Click the center of the ListItem element.
        /// </summary>
        /// <param name="rightClick">If true, performs a right-click; otherwise, performs a left-click. Default value is false</param>
        /// <param name="msPreAction">Pre action delay in milliseconds. Default value is 500</param>
        /// <param name="msPostAction">Post action delay in milliseconds. Default value is 500</param>
        public void ClickCenter(bool rightClick = false, int msPreAction = 500, int msPostAction = 500)
        {
            PerformAction(
                (actions, windowElement) =>
                {
                    actions.MoveToElement(windowElement);
                    if (rightClick)
                    {
                        actions.ContextClick();
                    }
                    else
                    {
                        actions.Click();
                    }

                    actions.Build().Perform();
                },
                msPreAction,
                msPostAction);
        }

        /// <summary>
        /// Double Click the ListItem element.
        /// </summary>
        public override void DoubleClick()
        {
            PerformAction((actions, windowElement) =>
            {
                actions.MoveToElement(windowElement, 10, 10);
                actions.DoubleClick();
                actions.Build().Perform();
            });
        }
    }
}
