using IOT_Class.Models;
using IOT_Class.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IOT_Class.Controllers
{
    public class DeviceAndModuleController : Controller
    {
        private readonly DataContext _data;

        public DeviceAndModuleController(DataContext data)
        {
            _data = data;
        }
        [HttpGet]
        public async  Task<IActionResult> Index()//cihazlar Listesi
        {
            var device = await _data.Devices.Where(x => x.IsDeleted == false && x.State==true).ToListAsync();
            var module =await _data.Modules.Where(x => x.IsDeleted == false && x.State == true).ToListAsync();

            DeviceWithModuleGetViewModel deviceWithModule = new DeviceWithModuleGetViewModel { 
            
            devices=device,
            modules=module      
            };
            

            return View(deviceWithModule);
        }
        [HttpGet]
        public IActionResult AddDevice()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddDevice(AddDevices addDevice)//Yeni Cihaz Ekleme
        {
            if (ModelState.IsValid)
            {
                Device device = new Device
                {
                    DeviceName=addDevice.deviceName,
                    Description=addDevice.description,
                    State=true
                };
                if (device != null)
                {
                    _data.Add(device);
                    _data.SaveChanges();
                    return RedirectToAction("Index", "DeviceAndModule");
                }

            }
            return View(addDevice);
        }
        [HttpGet]
        public async Task<IActionResult> GetModule()//Moduller Listesi
        {
            var module =await _data.Modules.Where(x => x.IsDeleted == false).ToListAsync();
            return View(module);
        }
        [HttpGet]
        public async Task<IActionResult> AddModule()
        {
            return View();
        }
        
        [HttpPost]
        public async Task<IActionResult> AddModule(AddModule addModule)//Yeni Cihaz Ekleme
        {
            if (ModelState.IsValid)
            {
                Module module = new Module {
                    ModuleName = addModule.moduleName,
                    DigitalMinValue = addModule.digitalMinValue,
                    DigitalMaxValue = addModule.digitalMaxValue,
                    AnalogMinValue = addModule.analogMinValue,
                    AnalogMaxValue = addModule.analogMaxValue,
                    State = true             
                };
                if (module != null)
                {
                    _data.Add(module);
                    _data.SaveChanges();
                    return RedirectToAction("GetModule", "DeviceAndModule");
                }
            }

            return View(addModule);
        }
        [HttpGet]
        public IActionResult EditModule(int id)//modül güncelleme
        {
            var modulevalue = _data.Modules.Find(id);
            return View(modulevalue);
        }
        [HttpPost]

        public IActionResult EditModule(Module module)//modül güncelleme
        {
            var moduleEdit = _data.Modules.Find(module.Id);
            try
            {
                moduleEdit.ModuleName = module.ModuleName;
                moduleEdit.DigitalMinValue = module.DigitalMinValue;
                moduleEdit.DigitalMaxValue = module.DigitalMaxValue;
                moduleEdit.AnalogMinValue = module.AnalogMinValue;
                moduleEdit.AnalogMaxValue = module.AnalogMaxValue;
                moduleEdit.State = module.State;
                _data.SaveChanges();
                return RedirectToAction("GetModule", "DeviceAndModule");

            }
            catch
            {
                return RedirectToAction("EditModule", "DeviceAndModule");

            }
        }
        public IActionResult DeleteModule(int id)
        {
            var modulevalue = _data.Modules.Find(id);
            modulevalue.IsDeleted = true;
            modulevalue.State = false;
            _data.SaveChanges();
            return RedirectToAction("GetModule", "DeviceAndModule");
        }
        [HttpGet]
        public async Task<IActionResult> AssignModuleForDevice(int id)//Cihaza modül atama
        {
            var assignDevice = _data.Devices.Where(x => x.Id == id).FirstOrDefault();
            List<Module> modules = _data.Modules.Where(x => x.State == true && x.IsDeleted == false).ToList();
            AssignModuleForDeviceViewModel assignModule = new AssignModuleForDeviceViewModel
            {
                device=assignDevice,
                modules=modules
            };
            return View(assignModule);
        }
        [HttpPost]
        public async Task<IActionResult> AssignModuleForDevice(AssignModuleForDeviceViewModel assignModule)
        {
            var assigndevice = _data.Devices.FirstOrDefault(x => x.Id == assignModule.device.Id);
            var module = _data.Modules.Find(assignModule.device.Module.Id);
            if (ModelState.IsValid)
            {
                assigndevice.Module = module;
                _data.Devices.Update(assigndevice);
                _data.SaveChanges();

            }
            return RedirectToAction("Index", "DeviceAndModule");


        }

    }
}
