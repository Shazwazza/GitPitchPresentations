---?color=#F2EBE6&image=template/img/umb/heart1.png&size=160px 160px&position=center

---?color=#3544B1
@title[Introduction]

## Umbraco Packages in v8

@snap[south span-100 text-07]
Shannon Deminick&nbsp;&nbsp;|&nbsp;&nbsp; @css[text-umb-pink](twitter): @shazwazza&nbsp;&nbsp;|&nbsp;&nbsp;@css[text-umb-pink](web): shazwazza.com
@snapend

---?color=#3544B1
@title[Agenda]

## Migrating<br/>Building<br/>Packaging

---?color=#F2EBE6

@title[Articulate]

@snap[west]
@img[split-screen-img span-80](template/img/umb/articulate.png)
@snapend

@snap[north-east text-20 text-bolder text-umb-blue]
Articulate
@snapend

@snap[east]
@ul[text-umb-dark-blue]
- Uses a __lot__ of Umbraco surface area
- A good way to test v8!
@olend
@snapend

---?color=#F2EBE6

@title[Surface Area]

@snap[west]
@img[split-screen-img span-80](template/img/umb/articulate.png)
@snapend

@snap[east]
@ul[text-umb-dark-blue]
- Custom routes & controllers
- Virtual nodes
- Content finders
- Event handlers
- Dashboards
- Property Editors
- Package manifest
- Lots of views
- Custom searching
- Custom DB queries
@olend
@snapend

---?color=#3544B1

@title[Migrating]

@snap[midpoint span-100 text-20]
## Migrating
@snapend

---?color=#3544B1

@snap[west span-45]
# MVC
@snapend

@snap[north-east span-60]
@box[bg-umb-grey text-umb-dark-blue rounded](Model# Published content and getting property values)
@snapend

@snap[east span-60]
@box[bg-umb-grey text-umb-dark-blue rounded](View# APIs available in Razor views)
@snapend

@snap[south-east span-60]
@box[bg-umb-grey text-umb-dark-blue rounded](Controller# Changes to controllers and how to create your own)
@snapend

---?color=#F2EBE6

@title[Published Content]

@snap[east text-20 text-bold text-umb-blue span-40]
Model changes
@snapend

@snap[west text-umb-dark-blue span-65]
@ul[split-screen-list text-08]
* RenderModel doesn't exist, just IPublishedContent
* One way to get property values
* No more dynamcis
@ulend
@snapend

---?color=#F2EBE6

@title[No RenderModel v7]

@snap[north-east text-umb-brown]
@css[text-umb-blue text-bolder](Page model)(v7)
@snapend

@code[html](template/src/page-model-v7.cshtml)

@[1](Default template header in v7)
@[2-5](UmbracoTemplatePage is really just this)
@[9](RenderModel is the page model)

---?color=#F2EBE6

@title[No RenderModel v8]

@snap[north-east text-umb-brown]
@css[text-umb-blue text-bolder](Page model)(v8)
@snapend

@code[html](template/src/page-model-v8.cshtml)

@[1](Default template header in v8)
@[2-5](UmbracoViewPage is really just this)
@[9](IPublishedContent is the model @fa[smile-o])

---?color=#3544B1

@title[Model.Value?]

## @css[text-umb-pink](@Model.Value) ?!

---?color=#F2EBE6

@title[Property Values v7]

@snap[north-east text-umb-brown]
@css[text-umb-blue text-bolder](Property values)(v7)
@snapend

@code[html zoom-09](template/src/prop-values-v7.cshtml)

@[2](If you want a recursive value you'd use Umbraco.Field)
@[4](One way to get a value in v7)
@[6](Typical way to get a value in v7)
@[7](Getting a strongly typed value in v7)

---?color=#F2EBE6

@title[Property Values v8]

@snap[north-east text-umb-brown]
@css[text-umb-blue text-bolder](Property values)(v8)
@snapend

@code[html zoom-09](template/src/prop-values-v8.cshtml)

@[2](Model.Value is used)
@[4](Model.Value is used)
@[6](Model.Value is used)
@[7](Model.Value is used)


---?color=#F2EBE6

@title[View APIs Traversal]

@snap[north text-umb-brown]
@css[text-umb-blue text-bolder](View APIs - Traversal)
@snapend

@snap[north-west text-umb-brown]
(v7)
@snapend

@snap[north-east text-umb-brown]
(v8)
@snapend

@snap[west span-50]
@code[cs zoom-09](template/src/view-apis-v7-traverse.cshtml)
@snapend

@snap[east span-50]
@code[cs zoom-09](template/src/view-apis-v8-traverse.cshtml)
@snapend

---?color=#F2EBE6

@title[View APIs Urls]

@snap[north text-umb-brown]
@css[text-umb-blue text-bolder](View APIs - URLs)
@snapend

@snap[north-west text-umb-brown]
(v7)
@snapend

@snap[north-east text-umb-brown]
(v8)
@snapend

@snap[west span-50]
@code[cs zoom-09](template/src/view-apis-v7-urls.cshtml)
@snapend

@snap[east span-50]
@code[cs zoom-09](template/src/view-apis-v8-urls.cshtml)
@snapend

---?color=#F2EBE6

@title[View APIs Lookup]

@snap[north text-umb-brown]
@css[text-umb-blue text-bolder](View APIs - Lookup)
@snapend

@snap[north-west text-umb-brown]
(v7)
@snapend

@snap[north-east text-umb-brown]
(v8)
@snapend

@snap[west span-50]
@code[cs zoom-09](template/src/view-apis-v7-lookup.cshtml)
@snapend

@snap[east span-50]
@code[cs zoom-09](template/src/view-apis-v8-lookup.cshtml)
@snapend

---?color=#3544B1

@title[No dynamics]

## ~~&nbsp;@CurrentPage&nbsp;~~

---?color=#3544B1

@title[XPath vs Linq]

## XPath vs Linq

@css[text-italic text-umb-pink text-08](v8's cache is __objects__, not XML)

---?color=#F2EBE6

@snap[north text-umb-brown]
@css[text-umb-blue text-bolder](View APIs - Services)
@snapend

@snap[north-west text-umb-brown]
(v7)
@snapend

@snap[north-east text-umb-brown]
(v8)
@snapend

@snap[west span-50]
@code[cs zoom-13](template/src/view-apis-v7-services.cshtml)
@snapend

@snap[east span-50]
@code[cs zoom-13](template/src/view-apis-v8-services.cshtml)
@snapend

---?color=#3544B1

@title[No singletons please]

## No singletons please 🙏🏻

@snap[south-west span-100]
@css[text-umb-pink text-08](Example:<br/>`@UmbracoContext.Current` <br/>instead of just<br/> `@UmbracoContext`)
@snapend

---?color=#F2EBE6

@title[Custom Controllers]

@snap[east text-20 text-bold text-umb-blue span-40]
Custom Controllers
@snapend

@snap[west text-umb-dark-blue span-55]
@ul[split-screen-list text-08]
* Typical controllers are still auto routed<br/><br/><small>`SurfaceController`<br/>`UmbracoApiController`</small>
* Controllers are constructed by DI
* Controllers must be registered in the DI Container
* Typical controllers are auto-registered<br/><br/><small>`PluginController`<br/>`IRenderMvcController`<br/>`UmbracoApiController`</small>
@ulend
@snapend

---?color=#3544B1

## DI = Dependency Injection

@title[DI is good]

@css[text-umb-pink](Guaranteed to make you code better)

---?color=#3544B1

## DI = Dependency Injection

@title[DI is easy]

@css[text-umb-pink](It's much easier than you think)

---?color=#3544B1

## Singletons are no good

@title[No Singletons]

---?color=#F2EBE6

@title[Bad Singletons]

@snap[west]
@img[split-screen-img span-60](template/img/umb/spaghetti.png)
@snapend

@snap[north-east text-15 text-bolder text-umb-blue]
Bad Singletons
@snapend

@snap[east span-60]
@ul[text-umb-dark-blue]
- Easily cause interdependencies
- Can't view dependency graph
- Difficult to debug
- Difficult to test
- Creates spaghetti code
@olend
@snapend

---?color=#F2EBE6

@title[Good Singletons]

@snap[west]
@img[split-screen-img span-60](template/img/umb/spaghetti.png)
@snapend

@snap[north-east text-15 text-bolder text-umb-blue]
Good Singletons?
@snapend

@snap[east span-60]
@ul[text-umb-dark-blue]
- c# Attributes
- __rarely__ in extension methods
@olend
@snapend

---?color=#F2EBE6

@title[Singletons API]

@snap[north text-umb-brown]
@css[text-umb-blue text-bolder](Singleton APIs)
@css[text-umb-dark-blue text-05](- If you must)
@snapend

@snap[north-west text-umb-brown]
(v7)
@snapend

@snap[north-east text-umb-brown]
(v8)
@snapend

@snap[west span-50]
@code[cs zoom-10](template/src/singletons-v7.cs)
@snapend

@snap[east span-50]
@code[cs zoom-10](template/src/singletons-v8.cs)
@snapend

---?color=#F2EBE6

@title[Composer]

@snap[north text-umb-brown]
@css[text-umb-blue text-bolder](Composers)
@snapend

@snap[south text-umb-dark-blue]
https://www.zpqrtbnk.net/posts/composing-umbraco-v8/
@snapend

@snap[north-west text-umb-brown]
(v7)
@snapend

@snap[north-east text-umb-brown]
(v8)
@snapend

@snap[west span-48]
@code[cs zoom-07](template/src/v7-application-event-handler.cs)
@snapend

@snap[east span-48]
@code[cs zoom-07](template/src/v8-composer.cs)
@snapend

---?color=#F2EBE6

@title[Register Controller]

@snap[north-east text-umb-brown]
@css[text-umb-blue text-bolder](Register custom controller)(v8)
@snapend

@code[cs](template/src/v8-register-controller.cs)

@[5-6](Lifetime is important)
@[8-9](Register a custom service)

---?color=#F2EBE6

@title[Controller changes]

@snap[north text-umb-brown]
@css[text-umb-blue text-bolder](Controller changes)
@snapend

@snap[north-west text-umb-brown]
(v7)
@snapend

@snap[north-east text-umb-brown]
(v8)
@snapend

@snap[west span-48]
@code[cs zoom-08](template/src/v7-controller.cs)
@snapend

@snap[east span-48]
@code[cs zoom-08](template/src/v8-controller.cs)
@snapend

@[4](v7 has RenderModel)
@[13](v8 has ContentModel)

---?color=#F2EBE6

@title[Controller injection]

@snap[north text-umb-brown]
@css[text-umb-blue text-bolder](Controller injection)(v8)
@snapend

@code[cs zoom-09](template/src/v8-controller-injection.cs)

@[3](Inject your custom service)
@[4](There are other dependencies, this are auto-gen'd by VS)
@[6,9](Store it in a field)
@[14](Use your custom service)

---?color=#3544B1

@title[Building]

@snap[midpoint span-100 text-20]
## Building
@snapend

---?color=#F2EBE6

@title[Package Manifest]

@snap[north text-umb-blue text-bolder]
Package Manifest

@css[text-umb-dark-blue text-05](/App_Plugins/MyPlugin/package.manifest)
@snapend

@code[json zoom-15](template/src/package-manifest.json)

@[2-6](Same as v7)
@[7-9](Shiny new v8 features)
@[7](Actually... I presented this here last here!)

---?color=#F2EBE6

@title[Dashboards]

@snap[north text-umb-blue text-bolder]
Dashboards
<br/>
@css[text-umb-dark-blue text-05 nowrap](https://our.umbraco.com/Documentation/Extending/Dashboards/index-v8)
@snapend

@code[json zoom-09](template/src/dashboards.json)

@[5](Dashboard alias)
@[6](Angular view to render)
@[7](The sections the dashboard will appear in)
@[8](Optional weight/order of the dashboard)
@[9-11](Optional access control)

---?color=#F2EBE6

@title[Dashboards c#]

@snap[north text-umb-blue text-bolder]
Dashboards in c#
<br/>
@css[text-umb-dark-blue text-05 nowrap](https://our.umbraco.com/Documentation/Extending/Dashboards/index-v8)
@snapend

@snap[south text-umb-dark-blue text-05 nowrap]
*__Currently__ assembly scanned*
@snapend

@code[csharp zoom-09](template/src/dashboards.cs)

---?color=#F2EBE6

@title[Sections]

@snap[north text-umb-blue text-bolder]
Sections
<br/>
@css[text-umb-dark-blue text-05 nowrap](<del>/config/applications.config</del>)
@snapend

@code[json](template/src/sections.json)

---?color=#F2EBE6

@title[Sections c#]

@snap[north text-umb-blue text-bolder]
Sections in c#
<br/>
@css[text-umb-dark-blue text-05 nowrap](<del>/config/applications.config</del>)
@snapend

@snap[south text-umb-dark-blue text-05 nowrap]
*Manually registered*
@snapend

@code[csharp](template/src/sections.cs)

---?color=#F2EBE6

@title[Full Screen Sections]

@snap[west text-umb-brown text-50]
@fa[tv]
@snapend

@snap[north-east text-20 text-bolder text-umb-blue]
Full Screen Sections!?
@snapend

@snap[east]
@ul[text-umb-dark-blue]
* Kind of happened by fluke
* Just a section + dashboard
* No tree required
* = No c# required
@olend
@snapend

---?color=#3544B1

@title[Building]

@snap[north span-100 text-15]
## Let's see!
@snapend

@snap[midpoint span-100 text-50 text-umb-pink]
@fa[laptop]
@snapend

---?color=#F2EBE6

@title[Package Options?]

@snap[west text-umb-brown text-50]
@fa[cubes]
@snapend

@snap[north-east text-20 text-bolder text-umb-blue]
Package Options!?
@snapend

@snap[south-east]
@img[split-screen-img span-54](template/img/umb/post-install-screen.png)
@snapend

---?color=#F2EBE6

@title[Package Options]

@snap[west text-umb-brown text-50]
@fa[cubes]
@snapend

@snap[north-east text-20 text-bolder text-umb-blue]
Package Options
@snapend

@snap[south-east]
@img[split-screen-img span-60](template/img/umb/package-options.png)
@snapend

---?color=#F2EBE6

@title[Package Options]

@snap[west text-umb-brown text-50]
@fa[cubes]
@snapend

@snap[north-east text-20 text-bolder text-umb-blue]
Package Options
@snapend

@snap[south-east]
@img[split-screen-img span-60](template/img/umb/package-options-view.png)
@snapend

---?color=#F2EBE6

@title[Package Options xml]

@snap[west text-umb-brown text-50]
@fa[cubes]
@snapend

@snap[north-east text-20 text-bolder text-umb-blue]
package.xml
@snapend

@snap[south-east]
@code[xml zoom-06](template/src/package.xml)
@snapend

---?color=#F2EBE6

@title[Package Options - view]

@snap[midpoint span-100]
@code[xml zoom-13](template/src/package-view.xml)
@snapend

---?color=#3544B1

@title[Packaging]

@snap[midpoint span-100 text-20]
## Packaging
@snapend

---?color=#F2EBE6

@title[Packaging in the back office]

@snap[west]
@img[split-screen-img span-80](template/img/umb/new-package.png)
@snapend

@snap[north-east text-20 text-bolder text-umb-blue]
Packaging UI
@snapend

@snap[east]
@ul[text-umb-dark-blue]
- Similar to v7
- Quick to choose schema, content & files
@olend
@snapend

---?color=#3544B1

## What about CI/CD?

TODO: Fill this in = powershell

TODO: Fill this in

---?color=#3544B1

## Nuget

TODO: Fill this in

---?color=#3544B1

## Package Actions

TODO: Fill this in, still a thing

## Data installation

TODO: Fill this in

