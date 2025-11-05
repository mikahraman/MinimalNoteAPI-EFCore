using Microsoft.EntityFrameworkCore;
using MinimalNoteAPI;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<NoteDb>(opt =>
    opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


app.MapGet("/notes", async (NoteDb db) =>
    await db.Notes.ToListAsync());


app.MapGet("/notes/{id}", async (int id, NoteDb db) =>
    await db.Notes.FindAsync(id)
        is Note note
            ? Results.Ok(note)
            : Results.NotFound());


app.MapPost("/notes", async (Note note, NoteDb db) =>
{
    db.Notes.Add(note);
    await db.SaveChangesAsync();
    return Results.Created($"/notes/{note.Id}", note);
});


app.MapPut("/notes/{id}", async (int id, Note inputNote, NoteDb db) =>
{
    var note = await db.Notes.FindAsync(id);
    if (note is null) return Results.NotFound();

    note.Text = inputNote.Text;
    note.IsDone = inputNote.IsDone;

    await db.SaveChangesAsync();
    return Results.NoContent();
});


app.MapDelete("/notes/{id}", async (int id, NoteDb db) =>
{
    if (await db.Notes.FindAsync(id) is Note note)
    {
        db.Notes.Remove(note);
        await db.SaveChangesAsync();
        return Results.Ok(note);
    }
    return Results.NotFound();
});


app.Run();