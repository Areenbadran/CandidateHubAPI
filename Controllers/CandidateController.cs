using CandidateHubAPI.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
    [Route("InsertCandidate")]
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

            await _context.SaveChangesAsync();
            return Ok(new { message = "Candidate information updated successfully." });
        }
        else
        {
            //insert new candidate
            await _context.Candidates.AddAsync(candidate);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(InsertCandidate), new { email = candidate.Email },
                                   new { message = "Candidate created successfully." });
        }
    }
}
