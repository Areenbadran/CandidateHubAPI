using CndidateHubAPI.Model;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RouteAttribute = Microsoft.AspNetCore.Components.RouteAttribute;

[ApiController]
[Route("api/[controller]")]
public class CandidateController : ControllerBase
{
    private readonly AppDbContext _context;

    public CandidateController(AppDbContext context)
    {
        _context = context;
    }

    [HttpPost]
    public async Task<IActionResult> InsertCandidate([FromBody] Candidate candidate)
    {
        var existingCandidate = await _context.Candidates
            .FirstOrDefaultAsync(c => c.Email == candidate.Email);

        //check if candidate by email is already exist
        if (existingCandidate != null)
        {
            //update candidate
            existingCandidate.FirstName = candidate.FirstName;
            existingCandidate.LastName = candidate.LastName;
            existingCandidate.PhoneNumber = candidate.PhoneNumber;
            existingCandidate.CallTimeInterval = candidate.CallTimeInterval;
            existingCandidate.LinkedInProfile = candidate.LinkedInProfile;
            existingCandidate.GitHubProfile = candidate.GitHubProfile;
            existingCandidate.FreeTextComment = candidate.FreeTextComment;
        }
        else
        {
            //insert candidate
            await _context.Candidates.AddAsync(candidate);
        }

        await _context.SaveChangesAsync();
        return Ok();
    }
}
