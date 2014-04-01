Calc4Lounger
============

懒人计算器
编译本工程源码没有什么特殊要求

其他内容详见 wiki 页面

thanks



GNU 较宽松公共许可证
============
1999.2, 第 2.1 版

版权所有 (C) 1991, 1999 Free Software Foundation, Inc.
59 Temple Place, Suite 330, Boston, MA 02111-1307 USA

允许每个人复制和发布本授权文件的完整副本，
但不允许对它进行任何修改。


本版本由 Leo-Hong (leohca (at) yahoo.com) 翻译整理, Chao-Hong Liu 校正.



导言


大多数软体许可证决意剥夺您共享和修改软体的自由。相反的，GNU 通用公共许可证力图保证您共享和修改自由软体的自由 —— 保证自由软体对所有使用者都是自由的。

这个许可证，较宽松公共许可证，适用于一些由自由软体基金会与其他决定使用此许可证的软体作者，所特殊设计的软体套件 —— 象是函数库。您也可以使用它，但我们建议您事先仔细考虑，基于以下的说明是否此许可证或原来的通用公共许可证在任何特殊情况下均为较好的方案。

当我们谈到自由软体时，我们所指的是自由，而不是价格。我们的 GNU 通用公共许可证是设计用以确保使您有发布自由软体备份的自由（如果您愿意，您可以对此项服务收取一定的费用）；确保您能收到程式原始码或者在您需要时能得到它；确保您能修改软体或将它的一部分用于新的自由软体；而且还确保您知道您可以做上述的这些事情。

为了保护您的权利，我们需要作出限制：禁止任何人否认您上述的权利，或者要求您放弃这些权利。如果您发布软件的副本，或者对之加以修改，这些规定就转化为您的责任。

例如，如果您发布此函数库的副本，不管是免费还是收取费用，您必须将您享有的一切权利给予接受者；您必须确保他们也能收到或得到原始程式码；如果您将此函数库与其他的程式码连结，您必须提供完整的目的对象文件和程序(object file)给接受者，则当他们修改此函数库并重新编译过后，可以重新与目的档连结。您并且要将这些条款给他们看，使他们知道他们有这样的权利。

我们采取两项措施来保护您的权利: （1）用版权来保护函数库。并且，（2）我们提供您这份许可证，赋予您复制，发布和（或）修改这些函数库的法律许可。
为了保护每个发布者，我们需要非常清楚地让每个人明白，自由函数库是没有担保责任的。如果由于某人修改了函数库，并继续加以传播，我们需要它的接受者明白：他们所得到的并不是原始的版本。故由其他人引入的任何问题，对原作者的声誉将不会有任何的影响。

最后，由于软体专利不断地威胁自由软体的存在，我们希望商业公司无法藉由自专利持有者取得一个受限的许可证，而有效地限制自由软体的使用者。因此，我们坚持一个函数库所能取得的任何专利，必须与本许可证所声明的“完全自由使用”一致。

大部分的 GNU 软体，包括一些函数库，是受到原来的 GNU 通用公共许可证的保护。本许可证， GNU 较宽松通用公共许可证，适用于特殊设计的函数库，且与原来的通用公共许可证有很大的不同。我们在特定的函数库中使用它，以准许非自由的程式可以与这些函数库连结。 当一个程式与一个函数库连结，不论是静态连结或使用共享函数库，二者的结合可以合理地说是结合的作品，一个原来的函数库的衍生品。因此，原来的通用公共许可证只有在整个结合品满足其自由的标准时，才予许连结。较宽松通用公共许可证则以更宽松的标准允许其他程式码与本函数库连结。

我们称此许可证 "较宽松" 通用公共许可证，是因为它比起原来的通用公共许可证对使用者的自由做到较少的保护。在与非自由软体竞争时，它也提供其他自由软体的写作者较少的优势。这些不利之处正是我们使用原来的通用公共许可证于许多函数库的理由。然而，较宽松的许可证可在某些特殊场合下带来好处。 例如，在少数情况下，可能会有特殊的需要而鼓励大家尽可能广泛地使用特定的函数库，因而使它成为实际上的标准。为了达到此目标，必须允许非自由的程式使用此函数库。一个较常发生的情况是一个自由的函数库与一个被广泛使用的非自由函数库做相同的工作，在此情况下，限制只有自由软体可以使用此自由函数库不会有多少好处，故我们如用了较宽松通用公共许可证。

在其他情况下，允许非自由程式使用特定的函数库，可以让更多的人们使用自由软体的大部分。例如，允许非自由程式使用 GNU C 函数库可以让更多的人们使用整个 GNU 作业系统，以及它的变形，GNU/Linux 作业系统。

尽管较宽松通用共公许可证对使用者的自由是较少的保护的，它却能确保与此函数库连结的程式的使用者拥有自由，而且具有使用修改过的函数库版本来执行该程式的必要方法。

以下是复制、发布、以及修改的精确条款与条件。请注意 "基于函数库的作品" 以及 "使用函数库的作品" 之间的差异：前者包含来自函数库修改过的原始码；而后者则必须与函数库结合才能执行。


有关复制，发布和修改的条款和条件


0. 本许可证适用于任何软体函数库，或其他包含了由版权所有者加入的注意事项的程式，或其他有公信力的团体宣称其程式可以在较宽松通用公共许可证 (也称之为 "本许可证") 的条款下发布。每一位许可证接受者以 "您" 来称呼。

一个 "函数库" 意指一些软体函数的集合，以及或准备好的资料以方便与应用程式 (其使用了其中某些函数与资料) 连结形成可执行的程式。

以下，"函数库" 一词指的是任何在本条款下发布的这一类软体函数库或作品，一个 "基于本函数库的作品" 意指函数库或任何在版权法下的衍生作品：也就是说，一个包含了本函数库或其一部分的作品，可以是原封不动的，或经过修改的，和/或直接翻译成其他语言的。(在下文中，翻译是不受限地包含在 "修改" 的条款中。)

作品的 "原始码" 意指对作品进行修改最优先择取的形式。对函数库而言，完整的原始码意指所有模组的所有原始程式，加上有关的介面的定义，加上控制函数库的安装和编译的 script。

本许可证条款不适用于复制，发布和修改以外的活动。这些活动超出这些条款的范围。使用本函数库来执行本程式的动作不受条款的限制，而程式的输出只有在其内容所构成的作品是基于本函数库时 (与在什么样的工具中使用本函数库来输出无关) ，这一条款才适用。以上是否为真则取决于本函数库具体用来做什么。

1. 只要您在每一程式副本上明显和恰当地宣告版权声明和不承担担保的声明，并保持此许可证的声明和没有担保的声明完整无损，并和程式一起给其他每位程式接受者一份许可证的副本，您就可以用任何媒体复制和发布您收到的函数库的完整原始码。

您可以为转让副本的实际行动收取一定费用。您也可以选择提供担保以换取一定的费用。

2. 只要您同时满足下面的所有条件，您就可以按前面第一款的要求修改函数库的一个或几个副本或它的任何部分，以此形成基于此函数库的作品，并且复制和发布这一经过修改的程式或作品:


被修改的作品本身必须是一个软体函数库。

您必须在修改过的档案中附有明确的说明：您修改了此一档案及任何修改的日期。

您必须让整个作品允许第三方在此许可证条款下可以免费使用。

如果修改过的函数库其某个设备使用到了「使用本函数库的应用程式」所提供的函数或资料表格，却不是当此设备被呼叫时以参数列传入时，则您必须确实做到，当应用程式不提供这样的函数或表格时，则此设备依旧能工作，且其执行的任何目的仍然有意义。
(例如，一个函数库的函数用来计算平方根，其目的是有完整的定义且与应用程式是无关的。因此， 2d 小节要求任何本函数会使用的，由应用程式所提供的函数或表格必须是选择性的：如果应用程式不提供的话，则计算平方根的函数必须依旧能计算平方根)

这些要求适用于整个修改过的作品。如果能够确定作品的一部分并非本函数库的衍生产品，且可以合理地单独考虑并将它与原作品分开的话，则当您将它作为独立的作品发布时，它不受此许可证和其条款的约束。但是当您将这部分与基于本函数库的作品一同发布时，则整个套件将受到本许可证条款约束，其对于其他许可证持有人的使用范围扩大到整个产品，也就是套件的每个部分，不管它是谁写的。

因此，本条款的意图不在于索取权利，或剥夺完全由您完成的作品的权利，而是履行权利来控制基于本函数库的集体作品或衍生作品的发布。 此外，将与本函数库无关的作品和本函数库 (或基于本函数库的作品) 一起放在贮存媒体或发布媒体的同一卷上，并不导致将其他作品置于此许可证的约束范围之内。

3. 对于一个函数库的副本，您可以选择性地使用原来的 GNU 通用公共许可证上的条款来取代本许可证上的条款。如果您要这么做，您必须修改所有的参考到本许可证的注意事项，使它们指向原来的 GNU 通用公共许可证，第二版，以取代本许可证(如果有比第二版的原来的 GNU 通用公共许可证更新的版本出现的话，则如果您愿意的话可以特别指明使用新版)。请不要对这些注意事项做出其他的改变。

一旦在一个副本上做了这样的改变，则该副本就无法撤回这样的改变，故原来的 GNU 通用公共许可证将适用于所有后续的副本以及由此副本衍生出来的作品。

此一选择性适用于当您想要将一部分的函数库原始码复制到一个非函数库的程式使用时。

4. 您可以以目标码或可执行形式复制或发布本函数库 (或符合第 2 款，基于本函数库的作品)，只要您遵守前面的第 1、2 款，并同时提供完整的相关机器可读的原始码，而这些原始码必须在前面的第 1 与第 2 款条件下，在一般习惯上用来做软体交换的媒体上发布。

如果所发布的目标码是由指定的地点提供拷贝索取，那么由同一地点所提供等价的原始码拷贝索取可以算作原始码的发布，即使第三方不强求与目标码一起复制原始码。

5. 一个程式若包含不经任何部分修改的函数库，但却是设计经由编译或连结的方式与本函数库一同工作者，称之为 "使用函数库的作品"。这样的一个作品，严格地说，并非本函数库的衍生作品，因而不在本许可证的范围之内。

然而，将 "使用函数库的作品" 与本函数库连结而产生可执行程式，则是本函数库的衍生品 (因为它包函了本函数库的一部分)，而不是 "使用函数库的作品"，因此其可执行程式包含在本许可证的范围内。第 6 款说明了发布此可执行程式的条款。

当 "使用函数库的作品" 使用了函数库部分的标头档内容时，则此作品即使其原始码不属于本函数库的衍生品，但其目标码仍然是。这一点是否为真特别在是否本作品可以在不需要本函数库即可连结，或者是否该作品本身也是一个函数库时特别明显。

如果这样的目标档只使用数字参数、资料结构层级与附属品、以及小巨集和小内□式 (小于或等于十行) ，则此目标档的使用是不受限的，不论是否它是合法的衍生作品。 (但可执行程式若包函此目标档以及一部分的函数库，仍然将在第 6 款的规定下)

否则的话，如果本作品是本函数库的衍生品，您必须在第 6 款的规定下发布该作品的目标码。任何包含该作品的可执行程式也在第 6 款的范围内，不论它们是否直接与本函数库连结。

6. 做为上述条款的例外情况，您也可以将 "使用函数库的作品" 与本函数库结合或连结，以产生包含部分本函数库的作品，并在允许使用者自身使用时可以修改该作品，以及在对修改进行反组译除错的情况下，您可以依照您的选择发布该作品。

您必须在每个作品的副本突显出如下的注意事项：本函数库在作品中被使用，以及本函数库以及它的使用是在本许可证的规定下。您必须提供本许可证的副本。如果该作品在执行时显示版权声明，您必须在其中包含本函数库的版权声明，以及指引使用者取得本许可证的副本。同时，您必须做到以下其中一件事： 


必须将完整的机器可读的函数库原始码包含在该作品中，包括任何该作品使用到的改变 (这些改变必须在前述第 1 与第 2 款的要求下发布)；而且，如果该作品是一个与函数库连结的「完整的、机器可□的 "使用函数库的作品"」，则要有目标码和/或原始码，如此使用者可以修改本函数库且可以重新连结，以产生包函修改过的函数库的修改过的可执行程式。 (理所当然的若使用者修改了函数库的档案定义内容时，则该作品不必然可以重新编译以使用修改过的定义。)

在与函数库连结时使用适当的分享函数库连结机制。一个适当的机制是： (1) 在执行时使用已存在于使用者的电脑中的函数库副本，而不是将函数库的函数复制到可执行程式里，以及 (2) 如果使用者安装了一份修改过的函数库，只要修改过的版本在介面上与该作品在编译连结时所用的版本是相容的，则该执行程式可以与修改过的函数库运作良好。

在该作品内提供书面报价，有效期不少于三年，以提供同样的使用者上述第 6a 款中的内容，费用不得超过该程式发布的实际成本。 如果所发布的作品是由指定的地点提供拷贝索取，则由同一地点提供上述内容的等价拷贝索取。

确定使用者已经收到该作品的一份复制，或是您已经寄给该使用者一份复制品。
对于一个可执行程式，其所需的 "使用函数库的作品" 的形式必须包括任何要从中再产生可执行程式时所需的资料与工具程式。然而，有一个特殊例外，其所发布的内容不需要包括任何一般与「可执行本程式的作业系统」的主要部分 (如编译器、核心等) 一起发布的部分 (不论是原始码或可执行码)，除非这些组成部分和可执行作品结合在一起。

有一个可能情况是，这些要求与其他通常不与作业系统在一起的私有函数库的版权限制相抵触，这样的抵触表示您不能将它们与本函数库一起用于您发布的可执行程式中。

7. 您可以将使用本函数库的函数库设备，以及其他不在本许可证范围内的函数库，对等地放入一个单独的函数库中，并在基于本函数库的作品以及其他函数库在其他状态下同意可以个别发布，以及您做到以下两点的情况下，您可以发布此结合的函数库：


将基于本函数库的作品单独不与其他函数库设备结合地，与此结合的函数库一同发布。该作品必须在上述条款的规定下发布。

在此结合的函数库中明显地指出其中一部分的作品是基于本函数库，并且说明那里可以找到同样不具结合形式的作品。 
8. 除非您明确按许可证提出的要求去做，否则您不能复制、修改、转发许可证、与本函数库连结、和发布本函数库。任何试图用其他方式复制、修改、转发许可证、与本函数库连结、和发布本函数库是无效的，而且将自动结束许可证赋予您的权利。然而，对那些从您那里按许可证条款得到副本和权利的人们，只要他们继续全面履行条款，许可证赋予他们的权利仍然有效。

9. 您没有在许可证上签字，因而您没有必要一定接受此一许可证。然而，没有任何其他东西赋予您修改和发布本函数库及其衍生作品的权利。如果您不接受许可证，这些行为是法律禁止的。因此，如果您修改或发布函数库 (或任何基于函数库的作品) ，您就表明您接受这一许可证以及它的所有有关复制、发布和修改本函数库或基于它的作品的条款和条件。

10. 每当您重新发布函数库 (或任何基于函数库的作品) 时，接受者自动从原始许可证颁发者那里接到受这些条款和条件支配的复制、发布、连结或修改本函数库的许可。您不可以强迫接受者履行除了这里赋予他们的权利之外的其他限制。您也没有强求第三方履行许可证条款的义务。

11. 如果由于法院判决或违反专利的指控或任何其他原因 (不限于专利问题) 的结果，使得强加于您的条件 (不管是法院判决，协议书或其他) 和许可证的条件有冲突时，他们也不能令您背离许可证的条款。在您不能同时满足本许可证规定的义务及其他相关的义务来发布函数库时，则结果您只能够根本不发布函数库。例如，如果某一专利许可证不允许所有直接或间接从您那里接受副本的人们，在不付专利费的情况下重新发布函数库，唯一能同时满足两方面要求的办法是停止发布函数库。

如果本条款的任何部分在特定的环境下无效或无法实施，就使用条款的其余部分，并将这部分条款作为整体用于其他环境。 本条款的目的不在于引诱您侵犯专利或其他财产权的要求，或争论这种要求的有效性。本条款的主要目的在于保护自由软体发布系统的完整性。它是通过公共许可证的应用来实现的。许多人已依赖同是出自此系统的应用程式，经由此系统发布大量自由软体而做出慷慨的供献。作者/捐献者有权决定他/她是否通过任何其他系统发布软体，许可证持有人不能强加这种选择。

本节的目的在于明确说明许可证其余部分可能产生的结果。

12. 如果由于专利或者由于有版权的介面问题使函数库在某些国家的发布和使用受到限制，则在许可证约束下的原始版权拥有者可以增加发布地区的限制条款，将这些国家明确排除在外，并在这些国家以外的地区发布函数库。在这种情况下，许可证套件含的限制条款和许可证正文一样有效。 13. 自由软体基金会可能随时出版较宽松通用公共许可证的修改版或新版。新版和当前的版本在原则上保持一致，但在提到新问题时或有关事项时，在细节上可能出现差别。

每一版本都有不同的版本号。如果函数库指定可适用的许可证版本号以及 "任何更新的版本" ，您有权选择遵循指定的版本或自由软体基金会以后出版的新版本。如果函数库未指定许可证版本，您可选择自由软体基金会已经出版的任何版本。 14. 如果您愿意将函数库的一部分结合到其他自由程式中，而它们的发布条件不同，请写信给作者，要求准予使用。如果是自由软体基金会加以版权保护的软体，写信给自由软体基金会，我们有时会作为例外的情况处理。我们的决定受两个主要目标的指导，这两个主要目标是：我们的自由软体的衍生作品继续保持自由状态，以及从整体上促进软体的共享和重复利用。

没有担保
15. 由于函数库准予免费使用，在适用法准许的范围内，对函数库没有担保。除非另有书面说明，版权所有者和/或其他提供函数库的人们 "一样" 不提供任何类型的担保，不论是明确的，还是隐含的，包括但不限于可销售和适合特定用途的隐含保证。全部的风险，如函数库的质量和性能问题都由您来承担。如果函数库出现缺陷，您应当承担所有必要的服务、修复和改正的费用。

16. 除非适用法或书面协议的要求，在任何情况下，任何版权所有者或任何按许可证条款修改和发布函数库的人们都不对您的损失负有任何责任。包括由于使用或不能使用函数库引起的任何一般的、特殊的、偶然发生的或重大的损失 (包括但不限于数据的损失，或者数据变得不精确，或者您或第三方的持续的损失，或者函数库不能和其他软体协调运行等) 。即使版权所有者和其他人提到这种损失的可能性也不例外。

-条文结束-

GNU GENERAL PUBLIC LICENSE
============
Version 2, June 1991

Copyright (C) 1989, 1991 Free Software Foundation, Inc.  
51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA

Everyone is permitted to copy and distribute verbatim copies
of this license document, but changing it is not allowed.
Preamble

The licenses for most software are designed to take away your freedom to share and change it. By contrast, the GNU General Public License is intended to guarantee your freedom to share and change free software--to make sure the software is free for all its users. This General Public License applies to most of the Free Software Foundation's software and to any other program whose authors commit to using it. (Some other Free Software Foundation software is covered by the GNU Lesser General Public License instead.) You can apply it to your programs, too.

When we speak of free software, we are referring to freedom, not price. Our General Public Licenses are designed to make sure that you have the freedom to distribute copies of free software (and charge for this service if you wish), that you receive source code or can get it if you want it, that you can change the software or use pieces of it in new free programs; and that you know you can do these things.

To protect your rights, we need to make restrictions that forbid anyone to deny you these rights or to ask you to surrender the rights. These restrictions translate to certain responsibilities for you if you distribute copies of the software, or if you modify it.

For example, if you distribute copies of such a program, whether gratis or for a fee, you must give the recipients all the rights that you have. You must make sure that they, too, receive or can get the source code. And you must show them these terms so they know their rights.

We protect your rights with two steps: (1) copyright the software, and (2) offer you this license which gives you legal permission to copy, distribute and/or modify the software.

Also, for each author's protection and ours, we want to make certain that everyone understands that there is no warranty for this free software. If the software is modified by someone else and passed on, we want its recipients to know that what they have is not the original, so that any problems introduced by others will not reflect on the original authors' reputations.

Finally, any free program is threatened constantly by software patents. We wish to avoid the danger that redistributors of a free program will individually obtain patent licenses, in effect making the program proprietary. To prevent this, we have made it clear that any patent must be licensed for everyone's free use or not licensed at all.

The precise terms and conditions for copying, distribution and modification follow.

TERMS AND CONDITIONS FOR COPYING, DISTRIBUTION AND MODIFICATION

0. This License applies to any program or other work which contains a notice placed by the copyright holder saying it may be distributed under the terms of this General Public License. The "Program", below, refers to any such program or work, and a "work based on the Program" means either the Program or any derivative work under copyright law: that is to say, a work containing the Program or a portion of it, either verbatim or with modifications and/or translated into another language. (Hereinafter, translation is included without limitation in the term "modification".) Each licensee is addressed as "you".

Activities other than copying, distribution and modification are not covered by this License; they are outside its scope. The act of running the Program is not restricted, and the output from the Program is covered only if its contents constitute a work based on the Program (independent of having been made by running the Program). Whether that is true depends on what the Program does.

1. You may copy and distribute verbatim copies of the Program's source code as you receive it, in any medium, provided that you conspicuously and appropriately publish on each copy an appropriate copyright notice and disclaimer of warranty; keep intact all the notices that refer to this License and to the absence of any warranty; and give any other recipients of the Program a copy of this License along with the Program.

You may charge a fee for the physical act of transferring a copy, and you may at your option offer warranty protection in exchange for a fee.

2. You may modify your copy or copies of the Program or any portion of it, thus forming a work based on the Program, and copy and distribute such modifications or work under the terms of Section 1 above, provided that you also meet all of these conditions:

a) You must cause the modified files to carry prominent notices stating that you changed the files and the date of any change.
b) You must cause any work that you distribute or publish, that in whole or in part contains or is derived from the Program or any part thereof, to be licensed as a whole at no charge to all third parties under the terms of this License.
c) If the modified program normally reads commands interactively when run, you must cause it, when started running for such interactive use in the most ordinary way, to print or display an announcement including an appropriate copyright notice and a notice that there is no warranty (or else, saying that you provide a warranty) and that users may redistribute the program under these conditions, and telling the user how to view a copy of this License. (Exception: if the Program itself is interactive but does not normally print such an announcement, your work based on the Program is not required to print an announcement.)
These requirements apply to the modified work as a whole. If identifiable sections of that work are not derived from the Program, and can be reasonably considered independent and separate works in themselves, then this License, and its terms, do not apply to those sections when you distribute them as separate works. But when you distribute the same sections as part of a whole which is a work based on the Program, the distribution of the whole must be on the terms of this License, whose permissions for other licensees extend to the entire whole, and thus to each and every part regardless of who wrote it.

Thus, it is not the intent of this section to claim rights or contest your rights to work written entirely by you; rather, the intent is to exercise the right to control the distribution of derivative or collective works based on the Program.

In addition, mere aggregation of another work not based on the Program with the Program (or with a work based on the Program) on a volume of a storage or distribution medium does not bring the other work under the scope of this License.

3. You may copy and distribute the Program (or a work based on it, under Section 2) in object code or executable form under the terms of Sections 1 and 2 above provided that you also do one of the following:

a) Accompany it with the complete corresponding machine-readable source code, which must be distributed under the terms of Sections 1 and 2 above on a medium customarily used for software interchange; or,
b) Accompany it with a written offer, valid for at least three years, to give any third party, for a charge no more than your cost of physically performing source distribution, a complete machine-readable copy of the corresponding source code, to be distributed under the terms of Sections 1 and 2 above on a medium customarily used for software interchange; or,
c) Accompany it with the information you received as to the offer to distribute corresponding source code. (This alternative is allowed only for noncommercial distribution and only if you received the program in object code or executable form with such an offer, in accord with Subsection b above.)
The source code for a work means the preferred form of the work for making modifications to it. For an executable work, complete source code means all the source code for all modules it contains, plus any associated interface definition files, plus the scripts used to control compilation and installation of the executable. However, as a special exception, the source code distributed need not include anything that is normally distributed (in either source or binary form) with the major components (compiler, kernel, and so on) of the operating system on which the executable runs, unless that component itself accompanies the executable.

If distribution of executable or object code is made by offering access to copy from a designated place, then offering equivalent access to copy the source code from the same place counts as distribution of the source code, even though third parties are not compelled to copy the source along with the object code.

4. You may not copy, modify, sublicense, or distribute the Program except as expressly provided under this License. Any attempt otherwise to copy, modify, sublicense or distribute the Program is void, and will automatically terminate your rights under this License. However, parties who have received copies, or rights, from you under this License will not have their licenses terminated so long as such parties remain in full compliance.

5. You are not required to accept this License, since you have not signed it. However, nothing else grants you permission to modify or distribute the Program or its derivative works. These actions are prohibited by law if you do not accept this License. Therefore, by modifying or distributing the Program (or any work based on the Program), you indicate your acceptance of this License to do so, and all its terms and conditions for copying, distributing or modifying the Program or works based on it.

6. Each time you redistribute the Program (or any work based on the Program), the recipient automatically receives a license from the original licensor to copy, distribute or modify the Program subject to these terms and conditions. You may not impose any further restrictions on the recipients' exercise of the rights granted herein. You are not responsible for enforcing compliance by third parties to this License.

7. If, as a consequence of a court judgment or allegation of patent infringement or for any other reason (not limited to patent issues), conditions are imposed on you (whether by court order, agreement or otherwise) that contradict the conditions of this License, they do not excuse you from the conditions of this License. If you cannot distribute so as to satisfy simultaneously your obligations under this License and any other pertinent obligations, then as a consequence you may not distribute the Program at all. For example, if a patent license would not permit royalty-free redistribution of the Program by all those who receive copies directly or indirectly through you, then the only way you could satisfy both it and this License would be to refrain entirely from distribution of the Program.

If any portion of this section is held invalid or unenforceable under any particular circumstance, the balance of the section is intended to apply and the section as a whole is intended to apply in other circumstances.

It is not the purpose of this section to induce you to infringe any patents or other property right claims or to contest validity of any such claims; this section has the sole purpose of protecting the integrity of the free software distribution system, which is implemented by public license practices. Many people have made generous contributions to the wide range of software distributed through that system in reliance on consistent application of that system; it is up to the author/donor to decide if he or she is willing to distribute software through any other system and a licensee cannot impose that choice.

This section is intended to make thoroughly clear what is believed to be a consequence of the rest of this License.

8. If the distribution and/or use of the Program is restricted in certain countries either by patents or by copyrighted interfaces, the original copyright holder who places the Program under this License may add an explicit geographical distribution limitation excluding those countries, so that distribution is permitted only in or among countries not thus excluded. In such case, this License incorporates the limitation as if written in the body of this License.

9. The Free Software Foundation may publish revised and/or new versions of the General Public License from time to time. Such new versions will be similar in spirit to the present version, but may differ in detail to address new problems or concerns.

Each version is given a distinguishing version number. If the Program specifies a version number of this License which applies to it and "any later version", you have the option of following the terms and conditions either of that version or of any later version published by the Free Software Foundation. If the Program does not specify a version number of this License, you may choose any version ever published by the Free Software Foundation.

10. If you wish to incorporate parts of the Program into other free programs whose distribution conditions are different, write to the author to ask for permission. For software which is copyrighted by the Free Software Foundation, write to the Free Software Foundation; we sometimes make exceptions for this. Our decision will be guided by the two goals of preserving the free status of all derivatives of our free software and of promoting the sharing and reuse of software generally.

NO WARRANTY

11. BECAUSE THE PROGRAM IS LICENSED FREE OF CHARGE, THERE IS NO WARRANTY FOR THE PROGRAM, TO THE EXTENT PERMITTED BY APPLICABLE LAW. EXCEPT WHEN OTHERWISE STATED IN WRITING THE COPYRIGHT HOLDERS AND/OR OTHER PARTIES PROVIDE THE PROGRAM "AS IS" WITHOUT WARRANTY OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE. THE ENTIRE RISK AS TO THE QUALITY AND PERFORMANCE OF THE PROGRAM IS WITH YOU. SHOULD THE PROGRAM PROVE DEFECTIVE, YOU ASSUME THE COST OF ALL NECESSARY SERVICING, REPAIR OR CORRECTION.

12. IN NO EVENT UNLESS REQUIRED BY APPLICABLE LAW OR AGREED TO IN WRITING WILL ANY COPYRIGHT HOLDER, OR ANY OTHER PARTY WHO MAY MODIFY AND/OR REDISTRIBUTE THE PROGRAM AS PERMITTED ABOVE, BE LIABLE TO YOU FOR DAMAGES, INCLUDING ANY GENERAL, SPECIAL, INCIDENTAL OR CONSEQUENTIAL DAMAGES ARISING OUT OF THE USE OR INABILITY TO USE THE PROGRAM (INCLUDING BUT NOT LIMITED TO LOSS OF DATA OR DATA BEING RENDERED INACCURATE OR LOSSES SUSTAINED BY YOU OR THIRD PARTIES OR A FAILURE OF THE PROGRAM TO OPERATE WITH ANY OTHER PROGRAMS), EVEN IF SUCH HOLDER OR OTHER PARTY HAS BEEN ADVISED OF THE POSSIBILITY OF SUCH DAMAGES.

END OF TERMS AND CONDITIONS
