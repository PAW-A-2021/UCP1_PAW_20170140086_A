using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DataVaksin.Models;

namespace DataVaksin.Controllers
{
    public class DataAnggotasController : Controller
    {
        private readonly DataVaksinContext _context;

        public DataAnggotasController(DataVaksinContext context)
        {
            _context = context;
        }

        // GET: DataAnggotas
        public async Task<IActionResult> Index()
        {
            return View(await _context.DataAnggota.ToListAsync());
        }

        // GET: DataAnggotas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dataAnggota = await _context.DataAnggota
                .FirstOrDefaultAsync(m => m.Nik == id);
            if (dataAnggota == null)
            {
                return NotFound();
            }

            return View(dataAnggota);
        }

        // GET: DataAnggotas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DataAnggotas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Nik,Nama,Umur,Pekerjaan,TempatTanggalLahir,JenisKelamin,JenisVaksin,Alamat,Foto")] DataAnggota dataAnggota)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dataAnggota);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dataAnggota);
        }

        // GET: DataAnggotas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dataAnggota = await _context.DataAnggota.FindAsync(id);
            if (dataAnggota == null)
            {
                return NotFound();
            }
            return View(dataAnggota);
        }

        // POST: DataAnggotas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Nik,Nama,Umur,Pekerjaan,TempatTanggalLahir,JenisKelamin,JenisVaksin,Alamat,Foto")] DataAnggota dataAnggota)
        {
            if (id != dataAnggota.Nik)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dataAnggota);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DataAnggotaExists(dataAnggota.Nik))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(dataAnggota);
        }

        // GET: DataAnggotas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dataAnggota = await _context.DataAnggota
                .FirstOrDefaultAsync(m => m.Nik == id);
            if (dataAnggota == null)
            {
                return NotFound();
            }

            return View(dataAnggota);
        }

        // POST: DataAnggotas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dataAnggota = await _context.DataAnggota.FindAsync(id);
            _context.DataAnggota.Remove(dataAnggota);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DataAnggotaExists(int id)
        {
            return _context.DataAnggota.Any(e => e.Nik == id);
        }
    }
}
