/* 
 * Copyright (C) 2007, Andrew Matthews http://aabs.wordpress.com/
 *
 * This file is Free Software and part of LinqToRdf http://code.google.com/p/linqtordf/
 *
 * It is licensed under the following license:
 *   - Berkeley License, V2.0 or any newer version
 *
 * You may not use this file except in compliance with the above license.
 *
 * See http://code.google.com/p/linqtordf/ for the complete text of the license agreement.
 *
 */
namespace LinqToRdf
{
	/// <summary>
	/// indictates what types of store can be used, and how they can be interacted with.
	/// </summary>
	public enum QueryType : int
	{
		LocalN3StoreInMemory,	// uses SemWeb to talk to a local in-memory store
		LocalN3StorePersistent,	// uses SemWeb to talk to a local RDBMS-based store (uses a suplementary connection string to identify type)
		LocalSparqlStore,		// uses SPARQL to communicate in-proc to a local triple store (platform agnostic)
		RemoteSparqlStore		// uses SPARQL to communicate via HTTP to a remote (or local) triple store (platform agnostic)
	}
}