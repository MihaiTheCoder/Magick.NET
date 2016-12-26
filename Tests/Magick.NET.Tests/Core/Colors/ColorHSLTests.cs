﻿//=================================================================================================
// Copyright 2013-2016 Dirk Lemstra <https://magick.codeplex.com/>
//
// Licensed under the ImageMagick License (the "License"); you may not use this file except in
// compliance with the License. You may obtain a copy of the License at
//
//   http://www.imagemagick.org/script/license.php
//
// Unless required by applicable law or agreed to in writing, software distributed under the
// License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
// express or implied. See the License for the specific language governing permissions and
// limitations under the License.
//=================================================================================================

using ImageMagick;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Magick.NET.Tests
{
  [TestClass]
  public class ColorHSLTests : ColorBaseTests<ColorHSL>
  {
    [TestMethod]
    public void Test_GetHashCode()
    {
      ColorHSL first = new ColorHSL(0.0, 0.0, 0.0);
      int hashCode = first.GetHashCode();

      first.Hue = first.Saturation = first.Lightness = 1.0;
      Assert.AreNotEqual(hashCode, first.GetHashCode());
    }

    [TestMethod]
    public void Test_IComparable()
    {
      ColorHSL first = new ColorHSL(0.4, 0.3, 0.2);

      Test_IComparable(first);

      ColorHSL second = new ColorHSL(0.1, 0.2, 0.3);

      Test_IComparable_FirstLower(first, second);

      second = new ColorHSL(0.4, 0.3, 0.2);

      Test_IComparable_Equal(first, second);
    }

    [TestMethod]
    public void Test_ImplicitOperator()
    {
      ColorHSL color = new ColorHSL(1.0, 1.0, 1.0);
      Test_ImplicitOperator(color, MagickColors.White);
    }

    [TestMethod]
    public void Test_ToString()
    {
      ColorHSL color = new ColorHSL(1.0, 1.0, 1.0);
      Test_ToString(color, MagickColors.White);
    }

    [TestMethod]
    public void Test_IEquatable()
    {
      ColorHSL first = new ColorHSL(1.0, 0.5, 0.5);

      Test_IEquatable_NullAndSelf(first);

      ColorHSL second = new ColorHSL(1.0, 0.5, 0.5);

      Test_IEquatable_Equal(first, second);

      second = new ColorHSL(1.0, 0.5, 1.0);

      Test_IEquatable_NotEqual(first, second);
    }
  }
}