// @model DetailedCleaningCompanyMVC.Models.Appointment
// @{
//     ViewData["Title"] = "Schedule an Appointment";
// }

// <div class="container-fluid p-4">
//     <form asp-controller="Home" asp-action="AppointmentForm" class="row g-3">
//         <div class="col-md-6">
//             <label asp-for="FirstName" class="form-label">First Name</label>
//             <input asp-for="FirstName" class="form-control" placeholder="First Name">
//             <span asp-validation-for="FirstName" class="text-danger"></span>
//         </div>
//         <div class="col-md-6">
//             <label asp-for="LastName" class="form-label">Last Name</label>
//             <input asp-for="LastName" class="form-control" placeholder="Last Name">
//             <span asp-validation-for="LastName" class="text-danger"></span>
//         </div>
//         <div class="col-12">
//             <label asp-for="Email" class="form-label">Email Address</label>
//             <input asp-for="Email" class="form-control" placeholder="MyEmail@email.com">
//             <span asp-validation-for="Email" class="text-danger"></span>
//         </div>
//         <div class="col-6">
//             <label asp-for="Number" class="form-label">Phone Number</label>
//             <input asp-for="Number" class="form-control" placeholder="XXX-XXX-XXXX">
//             <span asp-validation-for="Number" class="text-danger"></span>
//         </div>
//         <div class="col-md-4">
//             <label asp-for="City" class="form-label">City</label>
//             <select asp-for="City" class="form-select">
//             <option value="" selected>Choose...</option>
//             <option value="Elyria">Elyria</option>
//             <option value="Lorain">Lorain</option>
//             <option value="Avon">Avon</option>
//             </select>
//             <span asp-validation-for="City" class="text-danger"></span>
//         </div>
//         <div class="col-md-2">
//             <label asp-for="ZipCode" class="form-label">Zip</label>
//             <input asp-for="ZipCode" class="form-control">
//             <span asp-validation-for="ZipCode" class="text-danger"></span>
//         </div>
//         <div class="col-12">
//             <div class="form-check">
//                 <input asp-for="Agree" class="form-check-input" type="checkbox">
//                 <label asp-for="Agree" class="form-check-label">
//                     I agree to the terms and conditions
//                 </label>
//                 <span asp-validation-for="Agree" class="text-danger"></span>
//             </div>
//         </div>
//         <div class="col-12">
//             <button type="submit" class="btn btn-primary">Submit</button>
//         </div>
//     </form>
// </div>