using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PruebaNET_SantiagoPineda.Data;
using PruebaNET_SantiagoPineda.DTOs.GuestDTO;
using PruebaNET_SantiagoPineda.Models;
using PruebaNET_SantiagoPineda.Repositories;

namespace PruebaNET_SantiagoPineda.Services
{
    public class GuestService : IGuestRepository
    {
        protected readonly ApplicationDbContext _context;
        public GuestService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Add(GuestDTO guest)
        {
            var guest1 = new Guest
            {
                Id = guest.Id,
                FirstName = guest.FirstName,
                LastName = guest.LastName,
                Email = guest.Email,
                IdentificationNumber = guest.IdentificationNumber,
                PhoneNumber = guest.PhoneNumber,
                Birthdate = guest.BirthDate
            };
            _context.Guests.Add(guest1);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var guest = await _context.Guests.FindAsync(id);
            if (guest != null)
            {
                _context.Guests.Remove(guest);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<GuestDTO>> GetAll()
        {
            var guest = await _context.Guests.Select(guest => new GuestDTO
            {
                Id = guest.Id,
                FirstName = guest.FirstName,
                LastName = guest.LastName,
                Email = guest.Email,
                IdentificationNumber = guest.IdentificationNumber,
                PhoneNumber = guest.PhoneNumber,
                BirthDate = guest.Birthdate

            }).ToListAsync();
            return guest;
        }

        public async Task<GuestDTO> GetById(int id)
        {
            var room = await _context.Guests.Where(g => g.Id == id).Select(guest => new GuestDTO
            {
                Id = guest.Id,
                FirstName = guest.FirstName,
                LastName = guest.LastName,
                Email = guest.Email,
                IdentificationNumber = guest.IdentificationNumber,
                PhoneNumber = guest.PhoneNumber,
                BirthDate = guest.Birthdate
            }).ToListAsync();
            return room.FirstOrDefault();
        }

        public async Task<GuestDTO> GetByKeyword(string keyword)
        {
            var room = await _context.Guests.Where(g => g.FirstName.Contains(keyword) || g.LastName.Contains(keyword) || g.Email.Contains(keyword) || g.IdentificationNumber.Contains(keyword) || g.PhoneNumber.Contains(keyword)).Select(guest => new GuestDTO
            {
                Id = guest.Id,
                FirstName = guest.FirstName,
                LastName = guest.LastName,
                Email = guest.Email,
                IdentificationNumber = guest.IdentificationNumber,
                PhoneNumber = guest.PhoneNumber,
                BirthDate = guest.Birthdate
            }).ToListAsync();
            return room.FirstOrDefault();
        }

        public async Task Update(int id, GuestDTO guestDTO)
        {
            var guest = await _context.Guests.FindAsync(id);
            if (guest!= null)
            {
                guest.FirstName = guestDTO.FirstName;
                guest.LastName = guestDTO.LastName;
                guest.Email = guestDTO.Email;
                guest.IdentificationNumber = guestDTO.IdentificationNumber;
                guest.PhoneNumber = guestDTO.PhoneNumber;
                guest.Birthdate = guestDTO.BirthDate;
                _context.Entry(guest).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }
        }
    }
}