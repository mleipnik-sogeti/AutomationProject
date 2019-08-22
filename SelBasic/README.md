# SelBase
SelBase is an inherited class that establises all needed parts of a selenium web browser class including IWebDriver and Close()

# BBCommon
BBCommon is an inherited class that also inherits from SelBase. It Models the header that is common accross all of the Best Buy Developer website pages.

# BBHome
BBHome partially models the landing page for Best Buys Devloper website. It inherits from BBCommon as the page has the header on the page. 

# Login Page
Login page inherits from SelBase as it does not have a header.

# Layout
All files follow the general layout of By definitions, properties, constructor then function. This is up to personal preference and can be changed. 

# cheat Sheet:
Run test by name: dotnet test --filter name~BBHomeTestDevSup
run test by catagory: dotnet test --filter testcategory~Tutorial
web driver needs to be in same folder as csproj and in test/debug/netcoreapp
